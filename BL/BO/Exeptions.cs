namespace BO;

[Serializable]
public class BLidNotExistException : Exception
{
    public BLidNotExistException(string message) : base(message){}
    public BLidNotExistException(string message, Exception innerException)
                : base(message, innerException) { }

}
[Serializable]
public class BLidAlreadyExistException : Exception
{
    public BLidAlreadyExistException(string message) : base(message){}
    public BLidAlreadyExistException(string message, Exception innerException)
                : base(message, innerException) { }

}
[Serializable]
public class BLnotValidInputException : Exception
{
    public BLnotValidInputException(string message) : base(message){}
    public BLnotValidInputException(string message, Exception innerException)
                : base(message, innerException) { }

}

[Serializable]
public class BLOutOfStack : Exception
{
    public BLOutOfStack(string message) : base(message){}
   

}