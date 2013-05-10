using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acmp_0002_Sum
{
    /**
     * The summation from 1 to n
     */
    public class Sum
    {
        public Sum() {
            m_iSum = 0;
        }

        /**
         * Sums numbers from 1 to n
         * 
         * @param n The number
         * @return The sum
         */
        public int sum(int n)
        {
            if (n > 0) {
                for (int i = 1; i <= n; i++)
                {
                    m_iSum += i;
                }
            }
            else if (n == 0) {
                m_iSum = 1;
            }
            else if (n == -1)
            {
                m_iSum = 0;
            }
            else
            {
                for (int i = -2; i >= n; i--)
                {
                    m_iSum += i;
                }
            }

            return m_iSum;
        }

        /** The sum */
        private int m_iSum;
    }
}
