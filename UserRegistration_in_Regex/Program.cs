using UserRegistration_in_Regex;

Console.WriteLine("Welcome to Regular Expression Program \n");

#region FirstName
FirstName firstName = new FirstName();
if (firstName.ValidateFirstName("Nitish"))
{
    Console.WriteLine("The First Name is Valid");
}
else
    Console.WriteLine("The First Name is Invalid");
#endregion

#region LastName
LastName lastName = new LastName();
if (lastName.ValidateLastName("Kumar"))
{
    Console.WriteLine("The Last Name is Valid");
}
else
    Console.WriteLine("The Last Name is Invalid");
#endregion

#region Valid_Email
CheckEmail checkEmail = new CheckEmail();
if (checkEmail.ValidateEMail("abc.xyz@bl.co.in"))
{
    Console.WriteLine("The Email is Valid");
}
else
    Console.WriteLine("The Email is Invalid");
#endregion

#region MobileFormate
MobileFormate mobileFormate = new MobileFormate();
if (mobileFormate.ValidateMobileNo("91 9919819801"))
{
    Console.WriteLine("The Mobile Number is Valid");
}
else
    Console.WriteLine("The Mobile Number is Invalid");
#endregion

#region Password1_Minimum 8 Character
Password1_Min8Char Min8Char = new Password1_Min8Char();
if (Min8Char.ValidatePassword1("RanjanNitishKr"))
{
    Console.WriteLine("The Password1 is Valid");
}
else
    Console.WriteLine("The Password1 is Invalid");
#endregion

#region Password2_AtLeastOneUpperCase
Password2_AtLeastOneUpperCase AtLeastOneUpperCase = new Password2_AtLeastOneUpperCase();
if (AtLeastOneUpperCase.ValidatePassword2("Nitishkumar"))
{
    Console.WriteLine("The Password2 is Valid");
}
else
    Console.WriteLine("The Password2 is Invalid");
#endregion

#region Password3_AtLeastOneNumericNumber
Password3_AtLeastOneNumericNumber AtLeastOneNumericNumber = new Password3_AtLeastOneNumericNumber();
if (AtLeastOneNumericNumber.ValidatePassword3("Nitishkumar12"))
{
    Console.WriteLine("The Password3 is Valid");
}
else
    Console.WriteLine("The Password3 is Invalid");
#endregion

#region Password4_ExactlyOneSpecialCharacter
Password4_ExactlyOneSpecialCharacter ExactlyOneSpecialCharacter = new Password4_ExactlyOneSpecialCharacter();
if (ExactlyOneSpecialCharacter.ValidatePassword4("Nitishkumar@1234"))
{
    Console.WriteLine("The Password4 is Valid");
}
else
    Console.WriteLine("The Password4 is Invalid");
#endregion

#region Check_SampleEmails
SampleEmails sampleEmails = new SampleEmails();
if (sampleEmails.ValidateEmail("abc@gmail.com.com"))
{
    Console.WriteLine("The Sample Email is Valid");
}
else
    Console.WriteLine("The Sample Email is Invalid");
#endregion