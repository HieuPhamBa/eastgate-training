using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure.Quenue
{
    public class GenerateQuence<T>
    {
        private T[] arrItem;
        private int frontIndex, rearIndex;
        public int Size { get; set; }
        public int Length { get; set; }

        #region Constructor
        public GenerateQuence()
        {
            InitialQuence(10000);
        }

        public GenerateQuence(int length)
        {
            InitialQuence(length);
        }

        private void InitialQuence(int length)
        {
            Length = length;
            frontIndex = 0;
            rearIndex = -1;
            Size = 0;
            arrItem = new T[length];
        }
        #endregion

        #region Enquence, dequence
        public void Enquence(T obj)
        {

            if (rearIndex < Length)
            {
                arrItem[++rearIndex] = obj;
                Size++;
            }
            else
            {
                throw new Exception("Out of lenght of quence");
            }
        }

        public T Dequence()
        {
            if (IsEmpty())
            {
                throw new Exception("Quence is empty");
            }
            else
            {
                T frontItem = arrItem[frontIndex];
                frontIndex++;
                Size--;
                return frontItem;
            }
        }
        #endregion

        #region other function
        public bool IsEmpty()
        {
            return this.Size == 0;
        }

        public T Front()
        {
            if (this.Size == 0)
            {
                throw new Exception("Quence is empty");
            }
            return arrItem[frontIndex];
        }

        public T Rear()
        {
            if (this.Size == 0)
            {
                throw new Exception("Quence is empty");
            }
            return arrItem[rearIndex];
        }
        #endregion
    }
}
