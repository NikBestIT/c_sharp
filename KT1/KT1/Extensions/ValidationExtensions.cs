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
        [CallerMemberName] string? argName = null)
    {
        if (value <= minInvalidValue)
        {
            throw new ArgumentException($"{argName} должен быть больше {minInvalidValue}");                
        }

        return value;
    }

    public static string CheckNotNullOrEmptyOrWhiteSpace(
        this string value,
        [CallerMemberName] string? argName = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{argName} должена быть не пустой");
        }

        return value;
    }
}
