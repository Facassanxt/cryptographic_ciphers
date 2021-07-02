using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Matrix_cipher
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters; 
        readonly double[][] m;

        public Matrix_cipher(string key,string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet.ToUpper();
            string[] cols = key.Split(';');
            Console.WriteLine(cols.Length + " " + cols[0].Split(',').Length);
            m = MatrixCreate(cols.Length, cols[0].Split(',').Length);
            int count_c = 0;
            foreach (var item in cols)
            {
                string[] values = item.Split(',');
                int count_r = 0;
                foreach (var itm in values)
                {
                    m[count_c][count_r] = Convert.ToDouble(itm);
                    count_r++;
                }
                count_c++;
            }
        }
        private double[][] MatrixProduct(double[][] matrixA, double[][] matrixB)
        {
            int aRows = matrixA.Length; int aCols = matrixA[0].Length;
            int bRows = matrixB.Length; int bCols = matrixB[0].Length;
            if (aCols != bRows)
                throw new Exception("Несоответствие матрицы в MatrixProduct");

            // Проверка ошибок, вычисление aRows, aCols, bCols
            double[][] result = MatrixCreate(aRows, bCols);
            Parallel.For(0, aRows, i =>
            {
                for (int j = 0; j < bCols; ++j)
                    for (int k = 0; k < aCols; ++k)
                        result[i][j] += matrixA[i][k] * matrixB[k][j];
            }
            );
            return result;
        }

        static double[][] MatrixDuplicate(double[][] matrix)
        {
            // Предполагается, что матрица не нулевая
            double[][] result = MatrixCreate(matrix.Length, matrix[0].Length);
            for (int i = 0; i < matrix.Length; ++i) // Копирование значений
                for (int j = 0; j < matrix[i].Length; ++j)
                    result[i][j] = matrix[i][j];
            return result;
        }
        static double[] HelperSolve(double[][] luMatrix, double[] b)
        {
            // Решаем luMatrix * x = b
            int n = luMatrix.Length;
            double[] x = new double[n];
            b.CopyTo(x, 0);
            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum;
            }
            x[n - 1] /= luMatrix[n - 1][n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum / luMatrix[i][i];
            }
            return x;
        }

        private double[][] MatrixInverse(double[][] matrix)
        {
            int n = matrix.Length;
            double[][] result = MatrixDuplicate(matrix);
            int[] perm;
            int toggle;
            double[][] lum = MatrixDecompose(matrix, out perm, out toggle);
            if (lum == null)
                throw new Exception("Невозможно вычислить обратное");
            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }
                double[] x = HelperSolve(lum, b);
                for (int j = 0; j < n; ++j)
                    result[j][i] = x[j];
            }
            return result;
        }

        static double[][] MatrixDecompose(double[][] matrix, out int[] perm, out int toggle)
        {
            // Разложение LUP Дулитла. Предполагается,
            // что матрица квадратная.
            int n = matrix.Length; // для удобства
            double[][] result = MatrixDuplicate(matrix);
            perm = new int[n];
            for (int i = 0; i < n; ++i) { perm[i] = i; }
            toggle = 1;
            for (int j = 0; j < n - 1; ++j) // каждый столбец
            {
                double colMax = Math.Abs(result[j][j]); // Наибольшее значение в столбце j
                int pRow = j;
                for (int i = j + 1; i < n; ++i)
                {
                    if (result[i][j] > colMax)
                    {
                        colMax = result[i][j];
                        pRow = i;
                    }
                }
                if (pRow != j) // перестановка строк
                {
                    double[] rowPtr = result[pRow];
                    result[pRow] = result[j];
                    result[j] = rowPtr;
                    int tmp = perm[pRow]; // Меняем информацию о перестановке
                    perm[pRow] = perm[j];
                    perm[j] = tmp;
                    toggle = -toggle; // переключатель перестановки строк
                }
                if (Math.Abs(result[j][j]) < 1.0E-20)
                    return null;
                for (int i = j + 1; i < n; ++i)
                {
                    result[i][j] /= result[j][j];
                    for (int k = j + 1; k < n; ++k)
                        result[i][k] -= result[i][j] * result[j][k];
                }
            } // основной цикл по столбцу j
            return result;
        }

        static double[][] MatrixCreate(int rows, int cols)
        {
            // Создаем матрицу, полностью инициализированную
            // значениями 0.0. Проверка входных параметров опущена.
            double[][] result = new double[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new double[cols]; // автоинициализация в 0.0
            return result;
        }
        static string MatrixAsString(double[][] matrix)
        {
            string s = "";
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                    s += matrix[i][j].ToString() + " ";
                s += Environment.NewLine;
            }
            return s;
        }
        private double MatrixDeterminant(double[][] matrix)
        {
            int[] perm;
            int toggle;
            double[][] lum = MatrixDecompose(matrix, out perm, out toggle);
            if (lum == null)
                throw new Exception("Невозможно вычислить MatrixDeterminant");
            double result = toggle;
            for (int i = 0; i < lum.Length; ++i)
                result *= lum[i][i];
            return result;
        }

        static double[][] MatrixRandom(int rows, int cols, double minVal, double maxVal, int seed)
        {
            // Возвращаем матрицу со значениями
            // в диапазоне от minVal до maxVal
            Random ran = new Random(seed);
            double[][] result = MatrixCreate(rows, cols);
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                    result[i][j] = (maxVal - minVal) * ran.NextDouble() + minVal;
            return result;
        }
        static double[][] MatrixIdentity(int n)
        {
            double[][] result = MatrixCreate(n, n);
            for (int i = 0; i < n; ++i)
                result[i][i] = 1.0;
            return result;
        }
        static bool MatrixAreEqual(double[][] matrixA, double[][] matrixB, double epsilon)
        {
            // True, если все значения в A равны
            // соответствующим значениям в B
            int aRows = matrixA.Length;
            int aCols = matrixB[0].Length;
            for (int i = 0; i < aRows; ++i) // каждая строка A и B
                for (int j = 0; j < aCols; ++j) // каждый столбец A и B
                    if (Math.Abs(matrixA[i][j] - matrixB[i][j]) > epsilon)
                        return false;
            return true;
        }

        public string Encrypt(string text)
        {
            while (((double)text.Length / (double)m.Length) % 2 != 1 & ((double)text.Length / (double)m.Length) % 2 != 0)
                text += "Ф";
            string rez = "";
            for (int i = 0; i < text.Length; i++)
                rez += (letters.IndexOf(text[i]) + 1) + ",";
            rez = rez.Substring(0, rez.Length - 1);
            string[] subs = rez.Split(',');
            int t = subs.Length / m.Length;
            int temp = 0;
            rez = "";
            for (int s = 0; s < t; s++)
            {
                double[][] m_2 = MatrixCreate(m.Length, 1);
                for (int j = 0; j < m.Length; j++, temp++)
                    m_2[j][0] = Convert.ToDouble(subs[temp]);
                var r = MatrixProduct(m, m_2);
                int aRows = r.Length; int aCols = r[0].Length;
                for (int i = 0; i < aRows; ++i) // каждая строка A
                    for (int j = 0; j < aCols; ++j) // каждый столбец B
                        rez += r[i][j] + ",";
                Console.WriteLine(MatrixAsString(r));
            }

            Console.WriteLine(MatrixAsString(m));
            return rez.Substring(0, rez.Length - 1);
        }
        public string Decrypt(string Message)
        {
            double[][] i_5 = MatrixIdentity(m.Length);
            double[][] mi = MatrixProduct(m, i_5);
            string rez = "";
            if (MatrixAreEqual(m, mi, 0.00000001) == true)
            {
                double det = MatrixDeterminant(m);
                Console.WriteLine("Determinant = " + det.ToString());
                double[][] inverse = MatrixInverse(m);
                Console.WriteLine(MatrixAsString(inverse));

                string[] subs = Message.Split(',');
                int t = (subs.Length / inverse.Length);
                int temp = 0;
                for (int s = 0; s < t; s++)
                {
                    double[][] m_2 = MatrixCreate(inverse.Length, 1);
                    for (int j = 0; j < inverse.Length; j++, temp++)
                        m_2[j][0] = Convert.ToDouble(subs[temp]);
                    var r = MatrixProduct(inverse, m_2);
                    int aRows = r.Length; int aCols = r[0].Length;
                    for (int i = 0; i < aRows; ++i) // каждая строка A
                        for (int j = 0; j < aCols; ++j) // каждый столбец B
                            rez += letters[(int)Math.Round(r[i][j]) - 1];
                }
            }
            else
            {
                throw new Exception("Что-то не так");
            }
            return rez;
        }
    }
}
