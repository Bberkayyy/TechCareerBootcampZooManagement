namespace ZooManagement.Consts;

public class Messages
{
    public static string AnimalNotFoundExceptionMessage(int id)
    {
        return $"{id} numaralı id'ye ait hayvan bulunamadı.";
    }

    public static string EmployeeNotFoundExceptionMessage(int id)
    {
        return $"{id} numaralı id'ye ait çalışan bulunamadı.";
    }

    public static string AnimalTypeNotFoundExceptionMessage(string id)
    {
        return $"Girilen '{id}' kategorisine ait tür bulunamadı.";
    }

    public static string NameExceptionMessage(string name)
    {
        return $"Girilen isim '{name}' en az 3 karakterli olmalıdır. ({name.Length})";
    }

    public static string AnimalQuantityExceptionMessage(int quantity)
    {
        return $"Mevcut hayvan sayısı en az 1 olmalıdır.({quantity})";
    }

    public static string PhoneNumberExceptionMessage(string number)
    {
        return $"Lütfen numaranızı başında '0' olmadan 10 haneli olarak giriniz.({number.Length})";
    }

    public static string AgeExceptionMessage(int age)
    {
        return $"Çalışan yaşı 18'den küçük olamaz. ({age})";
    }
}