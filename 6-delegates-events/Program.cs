namespace _6_delegates_events
{

    // Simple Case of Delegate
    // 1. define new delegate for notification
    //  the pattern is: access modifier, return type, name, parameter list
    public delegate void NotificationDelegate(string message);

    // 2. define a class to handle the notification
    public class NotificationService {
        public void SendNotification(string message) {
            Console.WriteLine($"Sending notification: {message}");
        }

        public void SendSmsNotification (string message) {
            System.Console.WriteLine($"Deleting notification: {message}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("=== START SIMPLE CASE OF DELEGATE ===");
            // create an instance of the NotificationService class
            NotificationService notificationService = new NotificationService();

            // 3. create an instance of the delegate and assign it to the method
            NotificationDelegate notificationDelegate;

            notificationDelegate = notificationService.SendNotification;
            notificationDelegate("Welcome to our app!");

            System.Console.WriteLine("");

            notificationDelegate = notificationService.SendSmsNotification;
            notificationDelegate("Your  verification code is: 123456");
            System.Console.WriteLine("=== END SIMPLE CASE OF DELEGATE ===");

            System.Console.WriteLine("");   

            System.Console.WriteLine("===============================");    
            DelegateBasic.MyDelegate myDelegate = new DelegateBasic.MyDelegate(DelegateBasic.SayHello);
            myDelegate("World");

            System.Console.WriteLine("===============================");
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.onMessageReceived += subscriber.handleEvent;
            publisher.TriggerEvent("Hello, World!");

            System.Console.WriteLine("");
            System.Console.WriteLine("=== START SIMPLE CASE OF EVENTS ===");
            User user = new User();

            NotificationEventService notificationEventService = new NotificationEventService();

            user.StatusChanged += notificationEventService.OnUserStatusChanged;  

            user.Status = "Active";
            user.Status = "Inactive";

            System.Console.WriteLine("=== END SIMPLE CASE OF EVENTS ===");

        }

    }


    // Events
    public delegate void EventHandler(string message);
    public class Publisher {
        public event EventHandler? onMessageReceived;

        public void TriggerEvent(string message) {
            onMessageReceived?.Invoke(message);
        }
    }

    public class Subscriber {
        public void handleEvent(string message) {   
            System.Console.WriteLine($"Event trigger: {message}");
        }
    }

    // SAMPLE CASE OF EVENTS
    // 1. define a delegate for events
    public delegate void StatusChangeEventHandler(string message);

    public class User {
        public event StatusChangeEventHandler? StatusChanged;

        private string? _status;
        public string? Status {
            get {return _status;}

            set {
                if(_status != value) {
                    _status = value;
                    OnStatusChanged($"User is now: {_status}");
                }
            }
        }

        protected virtual void OnStatusChanged(string message) {
            StatusChanged?.Invoke(message); 
        }
    }

    public class NotificationEventService {
        public void OnUserStatusChanged(string message) {
            Console.WriteLine($"Notification: {message}");
        }
    }
}
