using System;

class Program {
  public static void Main (string[] args) {
    jobLeadList JLL = new jobLeadList();
    while(true){
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Add lead to head of list");
    Console.WriteLine("2. Add lead to tail of list");
    Console.WriteLine("3. Delete a lead");
    Console.WriteLine("4. Print List from head to tail");
    Console.WriteLine("5. Print List from tail to head");
    Console.WriteLine("6. Exit");
    string choice = Console.ReadLine();
    if (choice == "1"){
      Console.Write("Enter Company Name: ");
      string cname = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Contact Person Name: ");
      string pname = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Phone Number: ");
      string phnum = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Job Title: ");
      string jt = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Job Description: ");
      string des = Console.ReadLine();
      Console.WriteLine("");
      JLL.add_to_front(cname, pname, phnum, jt, des);
    
    }
    if (choice == "2"){
      Console.Write("Enter Company Name: ");
      string cname = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Contact Person Name: ");
      string pname = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Phone Number: ");
      string phnum = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Job Title: ");
      string jt = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Enter Job Description: ");
      string des = Console.ReadLine();
      Console.WriteLine("");
      JLL.add_to_back(cname, pname, phnum, jt, des);
    }
    if (choice == "3"){
      Console.WriteLine("Enter Company Name and Job Title");
      Console.Write("Company Name: ");
      string cn = Console.ReadLine();
      Console.WriteLine("");
      Console.Write("Job Title: ");
      string jt = Console.ReadLine();
    }
    if (choice == "4"){
      JLL.head_to_tail();
    }
    if (choice == "5"){
      JLL.tail_to_head();
    }
    if (choice == "6"){
      System.Environment.Exit(0);
      }
    }
  }
  public class JobLead {
    private string companyName;
    private string contactPerson;
    private string phoneNumber;
    private string jobTitle;
    private string jobDescription;
    public JobLead(string cn, string cp, string pn, string jt, string jd){
      this.companyName = cn;
      this.contactPerson = cp;
      this.phoneNumber = pn;
      this.jobTitle = jt;
      this.jobDescription = jd;
    }
    public void setCompanyName(string s){
      this.companyName = s;
    }
    public string getCompanyName(){
      return companyName;
    }
    public void setContactPerson(string s){
      this.contactPerson = s;
    }
    public string getContactPerson(){
      return contactPerson;
    }
    public void setPhoneNumber(string s){
      this.phoneNumber = s;
    }
    public string getPhoneNumber(){
      return phoneNumber;
    }
    public void setJobTitle(string s){
      this.jobTitle = s;
    }
    public string getJobTitle(){
      return jobTitle;
    }
    public void setJobDescription(string s){
      this.jobDescription = s;
    }
    public string getJobDescription(){
      return jobDescription;
    }
    public override string ToString(){
      return companyName + ", " + contactPerson + ", " + phoneNumber + ", " + jobTitle + ", " + jobDescription;
    }
      
  }

    public class jobLeadList{
      private Node first;
      private Node head;
      private Node tail;
      public jobLeadList(){
        this.first = null;
        this.head = null; 
        this.tail = null;
      }
      
      public void add_to_front(string cn, string cp, string pn, string jt, string jd){
      JobLead JL = new JobLead(cn, cp, pn, jt, jd);
      Node newNode = new Node(JL);
      newNode.next = first;
      first = newNode;
      }
     
      public void add_to_back(string cn, string cp, string pn, string jt, string jd){
        JobLead JL = new JobLead(cn, cp, pn, jt, jd);
        Node temp = new Node(JL);
        Node current = first;
        while (current.next != null){
          current = current.next;
        }
        current.next = temp;
      }
      
      public void remove_lead(string cn, string jt){
        Node curr = first;
        Node prev = curr;
        if ((curr.JL.getCompanyName() == cn) && (curr.JL.getJobTitle() == jt)){
          first = curr.next;
        }
        while ((curr.JL.getCompanyName() != cn) && (curr.JL.getJobTitle() != jt)){
          prev = curr;
          curr = curr.next;
          if(curr == null)
            return;    
   	  }
   	prev.next=curr.next;
      }
      public void head_to_tail(){
        if(first == null){
          Console.WriteLine("List is empty");
        }
        else{
        Node current = first;
        while (current.next != null){
          Console.WriteLine(current.JL);
          Console.WriteLine("");
          current = current.next;
          }
        }
      }
      public void tail_to_head(){
        Node curr = first;
        if(first == null){
          Console.WriteLine("List is empty");
        }
        else {
          while (curr != null){
            curr.next = curr;
          }
          while(curr != null){
            Console.WriteLine(curr.JL);
            curr = curr.prev;
          }
        }
      }
    }
      
  
    
    public class Node {
      public JobLead JL;
      public Node prev;
      public Node next;
      public Node(JobLead jl){
        this.JL = jl;
        next = null;
        prev = null;
      }
    }
}
