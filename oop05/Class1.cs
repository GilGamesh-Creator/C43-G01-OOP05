namespace oop05
{
    #region Q1
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
        double Length { get; set; }
        double Width { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with Radius: {Radius}, Area: {Area}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width}, Area: {Area}");
        }
    }
    //ICircle circle = new Circle { Radius = 5 };
    //IRectangle rectangle = new Rectangle { Length = 4, Width = 6 };
    //circle.DisplayShapeInfo();
    //rectangle.DisplayShapeInfo();
    #endregion
    #region Q2
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {         
            if (username == "user" && password == "password")
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {           
            if (username == "user" && role == "admin")
            {
                return true;
            }
            return false;
        }
    }
    //IAuthenticationService authService = new BasicAuthenticationService();       
    //    bool isAuthenticated = authService.AuthenticateUser("user", "password");
    //    bool isAuthorized = authService.AuthorizeUser("user", "admin");
    //        Console.WriteLine($"Is Authenticated: {isAuthenticated}");
    //        Console.WriteLine($"Is Authorized: {isAuthorized}");
    #endregion
    #region Q3
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
        }
    }

        //INotificationService emailService = new EmailNotificationService();
        //INotificationService smsService = new SmsNotificationService();
        //INotificationService pushService = new PushNotificationService();
        //emailService.SendNotification("user@example.com", "Hello via email!"); 
        //smsService.SendNotification("+1234567890", "Hello via SMS!"); 
        //pushService.SendNotification("deviceToken", "Hello via push notification!");
        #endregion
    }
