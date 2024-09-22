public class TimeService {
  public string GetTimeOfDay() {

    var time = DateTime.Now;
    var hour = time.Hour;
    string response = $" Time on server {time}\n";
    if (hour >= 12 && hour < 18) {
      response += "зараз день";
    } else if (hour >= 18 && hour < 24) {
      response += "зараз вечір";
    } else if (hour >= 0 && hour < 6) {
      response += "зараз ніч";
    } else {
      response += "зараз ранок";
    }
    return response;
  }
}
