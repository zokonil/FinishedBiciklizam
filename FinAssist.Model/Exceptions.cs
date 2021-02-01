using System;

namespace Biciklizam.Model
{
	public class BiciklistBaseException : Exception{}
	public class BiciklistRepoException : BiciklistBaseException{}
	public class BiciklistDoesNotExistException : BiciklistRepoException { }
    public class BiciklistOIBException : Exception { }
	public class BiciklistNameException : Exception { }
	public class BiciklistSurnameException : Exception { }

	public class UtrkaBaseException : Exception { }
	public class UtrkaRepoException : UtrkaBaseException { }
	public class UtrkaDoesNotExistException: UtrkaRepoException { }

	[Serializable]
	public class FinAssistBaseException : Exception
	{
	}

	[Serializable]
	public class NoExpSinkAccountException : FinAssistBaseException
	{
	}

	[Serializable]
	public class AccountDoesntExist : FinAssistBaseException
	{
	}

	[Serializable]
	public class AccountAlreadyExists : FinAssistBaseException
	{
	}

	[Serializable]
	public class ExpPlaceDoesntExist : FinAssistBaseException
	{
	}

	[Serializable]
	public class TransactionIndexException : FinAssistBaseException
	{
	}

	public class WrongAccountTypeNameInString : FinAssistBaseException
	{
	}

	public class AccountTypeNotInList : FinAssistBaseException
	{
	}

	public class TransactionIDAlreadyExists : FinAssistBaseException
	{
	}
}