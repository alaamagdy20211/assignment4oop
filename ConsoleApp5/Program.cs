namespace ConsoleApp5
{
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
        }
    }

    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string storedUsername = "admin";
        private readonly string storedPassword = "password";
        private readonly string storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area:F2}");
        }
    }

    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"SMS sent to {recipient}: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Push notification sent to {recipient}: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //            Question 1:
            //What is the primary purpose of an interface in C#?
            //Answer: b) To define a blueprint for a class

            //Question 2:
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //Answer: a) private

            //Question 3:
            //Can an interface contain fields in C#?
            //Answer: b) No

            //Question 4:
            //In C#, can an interface inherit from another interface?
            //Answer: b) Yes, interfaces can inherit from multiple interfaces

            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //Answer: d) implements

            //Question 6:
            //Can an interface contain static methods in C#?
            //Answer: a) Yes

            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //Answer: b) No, all members are implicitly public

            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //Answer: b) To provide a clear separation between interface and class members

            //Question 9:
            //In C#, can an interface have a constructor?
            //Answer: b) No, interfaces cannot have constructors

            //Question 10:
            //How can a C# class implement multiple interfaces?
            //Answer: c) By separating interface names with commas
            #endregion
            //ICircle circle = new Circle(5);
            //IRectangle rectangle = new Rectangle(4, 6);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            IAuthenticationService authService = new BasicAuthenticationService();

            bool isAuthenticated = authService.AuthenticateUser("admin", "password");
            Console.WriteLine($"User authenticated: {isAuthenticated}");

            bool isAuthorized = authService.AuthorizeUser("admin", "admin");
            Console.WriteLine($"User authorized: {isAuthorized}");

            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("alaamagdy3008@gmaolcom", "This is an email notification.");
            smsService.SendNotification("010907357098", "This is an SMS notification.");
            pushService.SendNotification("alaamagdy123", "This is a push notification.");

        }
    }
}
