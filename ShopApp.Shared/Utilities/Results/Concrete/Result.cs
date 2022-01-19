﻿using ShopApp.Shared.Utilities.Results.Abstract;
using ShopApp.Shared.Utilities.Results.ComplexTypes;

namespace ShopApp.Shared.Utilities.Results.Concrete;

public class Result : IResult
{
    public Result(ResultStatus resultStatus)
    {
        ResultStatus = resultStatus;
    }

    public Result(ResultStatus resultStatus, string message)
    {
        ResultStatus = resultStatus;
        Message = message;
    }

    public Result(ResultStatus resultStatus, string message, Exception exception)
    {
        ResultStatus = resultStatus;
        Message = message;
        Exception = exception;
    }

    public ResultStatus ResultStatus { get; }
    public string Message { get; }
    public Exception Exception { get; }
}