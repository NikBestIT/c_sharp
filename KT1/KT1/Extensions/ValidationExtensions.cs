using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KT1.Extensions;

/// <summary>
/// Предназначен для валидации параметров методов
/// </summary>
public static class ValidationExtensions
{
    public static int CheckGreaterThan(
        this int value, 
        int minInvalidValue = 0, 
        [CallerFilePath]  string? filePath = null,
        [CallerArgumentExpression(nameof(value))] string? argName = null)
    {
        if (value <= minInvalidValue)
        {
            throw new ArgumentException($"'{filePath}' - {argName} должен быть больше {minInvalidValue}");                
        }

        return value;
    }
    public static int CheckValidAge(
        this int age, 
        int minValidAge = 7, 
        int maxValidAge = 100, 
        [CallerFilePath]  string? filePath = null,
        [CallerArgumentExpression(nameof(age))] string? argName = null)
    {
        if (age < minValidAge || age > maxValidAge)
        {
            throw new ArgumentException($"'{filePath}' - {argName} должен быть в диапазоне [{minValidAge}, {maxValidAge}]");                
        }

        return age;
    }

    public static string CheckNotNullOrEmptyOrWhiteSpace(
        this string value,
        [CallerFilePath]  string? filePath = null,
        [CallerArgumentExpression(nameof(value))] string? argName = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"'{filePath}' - {argName} должен быть не пустой строкой");
        }

        return value;
    }

    public static string[] CheckNotNullOrEmptyOrEmptyElements(
        this string[]? value,
        [CallerFilePath]  string? filePath = null,
        [CallerArgumentExpression(nameof(value))] string? argName = null)
    {
        if (value == null || value.Length == 0 || value.Any(string.IsNullOrWhiteSpace))
        {
            throw new ArgumentException($"'{filePath}' - {argName} должно быть не null и не пустой коллекцией не пустых строк");
        }

        return value;
    }
}
