

namespace DO;
[Serializable]
public class DALidNotExistException:Exception
{
    public DALidNotExistException(string message):base(message)
    {
     
    }
}
[Serializable]
public class DALidalreadyExistException : Exception
{
    public DALidalreadyExistException(string message) : base(message)
    {

    }
}
[Serializable]
public class DALnotValidInputException : Exception
{
    public DALnotValidInputException(string message) : base(message)
    {

    }
}