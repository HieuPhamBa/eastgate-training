using System;

namespace data_structure.Quenue
{
    public class NumberQueue
    {
        private int[] arrNumber;
        private int frontIndex, rearIndex;
        public int Size { get; set; }
        public int Length { get; set; }

        #region Constructor
        public NumberQueue()
        {
            InitialQuence(Int32.MaxValue);
        }

        public NumberQueue(int length)
        {
            InitialQuence(length);
        }

        private void InitialQuence(int length)
        {
            Length = length;
            frontIndex = 0;
            rearIndex = -1;
            Size = 0;
            arrNumber = new int[length];
        }
        #endregion

        #region Enquence, dequence
        public void Enquence(int number)
        {

            if (rearIndex < Length)
            {
                arrNumber[++rearIndex] = number;
                Size++;
            }
            else
            {
                throw new Exception("Out of lenght of quence");
            }
        }

        public int Dequence()
        {
            if (IsEmpty())
            {
                throw new Exception("Quence is empty");
            }
            else
            {
                int frontItem = arrNumber[frontIndex];
                frontIndex++;
                Size--;
                return frontItem;
            }
        }
        #endregion

        #region other function
        public bool IsEmpty()
        {
            return this.Size==0;
        }

        public int Front()
        {
            if (this.Size == 0)
            {
                throw new Exception("Quence is empty");
            }
            return arrNumber[frontIndex];
        }

        public int Rear()
        {
            if (this.Size == 0)
            {
                throw new Exception("Quence is empty");
            }
            return arrNumber[rearIndex];
        }
        #endregion
    }
}
