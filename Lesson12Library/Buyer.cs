namespace Lesson12Library;

public class Buyer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public List<Buyer> buyers = new List<Buyer>();

    public void AddNewBuyer(string FirstName, string LastName, string Email, string Phone)
    {
        Buyer newBuyer = new Buyer();
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.Phone = Phone;

        buyers.Add(newBuyer);
    }


}