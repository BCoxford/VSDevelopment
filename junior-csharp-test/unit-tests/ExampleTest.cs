using System;
using System.Linq;
using Dapper;
using ui;
using Xunit;

namespace unit_tests
{
    public class ExampleTest
    {
        private Database db = new Database();
        [Fact]
        public void FetchAllOrderNumber()
        {
            var dbResult = db.FetchAllOrderNumbers();
            var actualResult = dbResult.Count();
            var expectedResult = 30000; //Update to SQL query COUNT

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FetchOrderDetailsByDate()
        {

            var startDate = new DateTime(2015, 1, 1);
            var endDate = new DateTime(2020, 1, 1);

            var dbResult = db.FetchOrderNumbersByDate(startDate, endDate);
            var actualResult = dbResult.Count();
            var expectedResult = 14836; //Update to SQL query COUNT

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void FetchOrderDetailsByOrderNumber()
        {
            var input = new[] { 2, 500, 200, 10000000 };
            var expectedResult = new[] { 2, 500, 200, -1 };
            var actualResult = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var result = db.FetchOrderDetails(input[i]);
                if (result.Count() == 1)
                {
                    foreach (var o in result)
                    {
                        actualResult[i] = o.order_number;
                    }
                }
                else
                {
                    actualResult[i] = -1; //-1 indicates the order does not exist in the database
                }
            }

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void NumberValidation()
        {
            var input = new[] { "10", "24", "3", "f", "+", "-" };
            var expectedResult = new int[] { 10, 24, 3, -1, -1, -1 }; //-1 indicates the value is not numerical

            Form1 form = new Form1();

            var actualResult = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                int result = form.validateOrderNumber(input[i]);
                actualResult[i] = result;
            }

            Assert.Equal(expectedResult, actualResult);
        }
    }
}