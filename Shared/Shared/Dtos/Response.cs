﻿using System.Text.Json.Serialization;

namespace Shared.Dtos;

public class Response<T>
{
    public T Data { get; set; }

    [JsonIgnore]
    public int StatusCode { get; set; }

    public bool IsSuccessful { get; set; }

    public List<string> Errors { get; set; }

    public string? Message { get; set; }

    public static Response<T> Success(T data, int statusCode, string? message)
    {
        return new Response<T>
        {
            Data = data,
            StatusCode = statusCode,
            IsSuccessful = true,
            Message = message ?? string.Empty
        };
    }

    public static Response<T> Success(int statusCode, string? message)
    {
        return new Response<T>
        {
            Data = default(T),
            StatusCode = statusCode,
            IsSuccessful = true,
            Message = message ?? string.Empty
        };
    }

    public static Response<T> Fail(List<string> errors, int statusCode)
    {
        return new Response<T>
        {
            Errors = errors,
            StatusCode = statusCode,
            IsSuccessful = false
        };
    }

    public static Response<T> Fail(string error, int statusCode)
    {
        return new Response<T>
        {
            Errors = new List<string>() { error },
            StatusCode = statusCode,
            IsSuccessful = false
        };
    }
}