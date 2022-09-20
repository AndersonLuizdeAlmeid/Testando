using CSharpFunctionalExtensions;

namespace DeliveryRoutes.Domain
{
    public class DMYDate
    {
        public DMYDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year:D4}";
        }

        public static Result<DMYDate> Create(string dmyDate)
        {
            var date = dmyDate.Split("/");
            if (date.Length != 3)
                return Result.Failure<DMYDate>("Data está em formato inválido, DD/MM/AAAA");

            return new DMYDate(Int32.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
                
        }
    }
}