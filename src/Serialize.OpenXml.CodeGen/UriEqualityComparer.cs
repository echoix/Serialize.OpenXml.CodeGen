/* MIT License

Copyright (c) 2020 Ryan Boggs

Permission is hereby granted, free of charge, to any person obtaining a copy of this
software and associated documentation files (the "Software"), to deal in the Software
without restriction, including without limitation the rights to use, copy, modify,
merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be included in all copies
or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;

namespace Serialize.OpenXml.CodeGen;

/// <summary>
/// Equality comparer class used to ensure that circular part references are
/// avoided when trying to build source code for <see cref="OpenXmlPart"/>
/// objects.
/// </summary>
public sealed class UriEqualityComparer : EqualityComparer<Uri>
{
    #region Public Static Fields

    /// <summary>
    /// A default <see cref="UriEqualityComparer"/> to use when comparing 2
    /// <see cref="Uri"/> objects.
    /// </summary>
    public static readonly UriEqualityComparer DefaultComparer = new();

    #endregion

    #region Public Instance Methods

    /// <inheritdoc/>
    public override bool Equals(Uri x, Uri y)
    {
        return x != null && y != null && x == y;
    }

    /// <inheritdoc/>
    public override int GetHashCode(Uri obj)
    {
        return obj.ToString().GetHashCode();
    }

    #endregion
}
