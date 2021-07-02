﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class A5_1
    {
        private bool[] reg = new bool[19];
        private bool[] reg2 = new bool[22];
        private bool[] reg3 = new bool[23];

        //конструктор, который позволяет сразу установить начальное состояние регистров и нужное значение
        public A5_1(bool[][] startState)
        {
            reg = startState[0];
            reg2 = startState[1];
            reg3 = startState[2];
        }

        public A5_1()
        {
            for (int i = 0; i < 19; i++)
                reg[i] = false;
            for (int i = 0; i < 22; i++)
                reg2[i] = false;
            for (int i = 0; i < 23; i++)
                reg3[i] = false;
        }

        //нормальная инициализация регистров, используется при обычном вызове метода A5
        public void KeySetup(byte[] key, int[] frame)
        {
            for (int i = 0; i < 19; i++)
                reg[i] = false;
            for (int i = 0; i < 22; i++)
                reg2[i] = false;
            for (int i = 0; i < 23; i++)
                reg3[i] = false;
            BitArray KeyBits = new BitArray(key);
            BitArray FrameBits = new BitArray(frame);
            bool[] b = new bool[64];
            for (int i = 0; i < 64; i++)
            {
                clockall();
                reg[0] = reg[0] ^ KeyBits[i];
                reg2[0] = reg2[0] ^ KeyBits[i];
                reg3[0] = reg3[0] ^ KeyBits[i];
            }
            for (int i = 0; i < 22; i++)
            {
                clockall();
                reg[0] = reg[0] ^ FrameBits[i];
                reg2[0] = reg2[0] ^ FrameBits[i];
                reg3[0] = reg3[0] ^ FrameBits[i];
            }
            for (int i = 0; i < 100; i++)
            {
                clock();
            }
        }

        //частичная инициализация, в регистры грузится только номер фрейма
        public void KeySetup(int[] frame)
        {
            BitArray FrameBits = new BitArray(frame);
            for (int i = 0; i < 22; i++)
            {
                clockall();
                reg[0] = reg[0] ^ FrameBits[i];
                reg2[0] = reg2[0] ^ FrameBits[i];
                reg3[0] = reg3[0] ^ FrameBits[i];
            }
            for (int i = 0; i < 100; i++)
            {
                clock();
            }
        }

        private void clock()
        {
            bool majority = ((reg[8] & reg2[10]) | (reg[8] & reg3[10]) | (reg2[10] & reg3[10]));
            if (reg[8] == majority)
                clockone(reg);

            if (reg2[10] == majority)
                clocktwo(reg2);

            if (reg3[10] == majority)
                clockthree(reg3);
        }

        //набор функций реализующих сдвиги регистров
        private bool[] clockone(bool[] RegOne)
        {
            bool temp = false;
            for (int i = RegOne.Length - 1; i > 0; i--)
            {
                if (i == RegOne.Length - 1)
                    temp = RegOne[13] ^ RegOne[16] ^ RegOne[17] ^ RegOne[18];
                RegOne[i] = RegOne[i - 1];
                if (i == 1)
                    RegOne[0] = temp;
            }
            return RegOne;
        }

        private bool[] clocktwo(bool[] RegTwo)
        {
            bool temp = false;
            for (int i = RegTwo.Length - 1; i > 0; i--)
            {
                if (i == RegTwo.Length - 1)
                    temp = RegTwo[20] ^ RegTwo[21];
                RegTwo[i] = RegTwo[i - 1];
                if (i == 1)
                    RegTwo[0] = temp;
            }
            return RegTwo;
        }

        private bool[] clockthree(bool[] RegThree)
        {
            bool temp = false;
            for (int i = RegThree.Length - 1; i > 0; i--)
            {
                if (i == RegThree.Length - 1)
                    temp = RegThree[7] ^ RegThree[20] ^ RegThree[21] ^ RegThree[22];
                RegThree[i] = RegThree[i - 1];
                if (i == 1)
                    RegThree[0] = temp;
            }
            return RegThree;
        }

        private void clockall()
        {
            reg = clockone(reg);
            reg2 = clocktwo(reg2);
            reg3 = clockthree(reg3);
        }

        //метод возвращающий 114 бит сгенерированного потока
        public bool[] A5()
        {
            bool[] FirstPart = new bool[114];
            for (int i = 0; i < 114; i++)
            {
                clock();
                FirstPart[i] = (reg[18] ^ reg2[21] ^ reg3[22]);
            }
            return FirstPart;
        }

        //метод возвращающий всю 228 битную последовательность сгенерированного потока
        public bool[] A5(bool AsFrame)
        {
            bool[] FirstPart = new bool[228];
            for (int i = 0; i < 228; i++)
            {
                clock();
                FirstPart[i] = (reg[18] ^ reg2[21] ^ reg3[22]);
            }
            return FirstPart;
        }

        public byte[] FromBoolToByte(bool[] key, bool lsb)
        {
            int bytes = key.Length / 8;
            if ((key.Length % 8) != 0) bytes++;
            byte[] arr2 = new byte[bytes];
            int bitIndex = 0, byteIndex = 0;
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i])
                {
                    if (lsb)
                        arr2[byteIndex] |= (byte)(((byte)1) << (7 - bitIndex));
                    else
                        arr2[byteIndex] |= (byte)(((byte)1) << (bitIndex));
                }
                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }
            return arr2;
        }

        public byte[] A5Encyptor(byte[] msg, byte[] key)
        {
            var msgbits = new BitArray(msg);
            int[] frame = new int[1];
            bool[] resbits = new bool[msgbits.Count];
            int framesCount = msgbits.Length / 228;

            if ((msgbits.Count % 228) != 0)
                framesCount++;
            for (int i = 0; i < framesCount; i++)
            {
                frame[0] = i;

                KeySetup(key, frame);
                bool[] KeyStream = A5(true);
                for (int j = 0; j < 228 && j < msgbits.Count; j++)
                {
                    var msgIndex = i * 228 + j;
                    if (msgIndex >= msgbits.Count)
                        break;
                    resbits[msgIndex] = msgbits[msgIndex] ^ KeyStream[j];
                }
            }
            return FromBoolToByte(resbits, false);
        }
    }
}
