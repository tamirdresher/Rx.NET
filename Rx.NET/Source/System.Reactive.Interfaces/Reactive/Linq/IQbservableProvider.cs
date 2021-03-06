// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

#if !NO_EXPRESSIONS
using System.Linq.Expressions;

namespace System.Reactive.Linq
{
    /// <summary>
    /// Defines methods to create and execute queries that are described by an IQbservable object.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Qbservable", Justification = "What a pleasure to write 'by design' here.")]
    public interface IQbservableProvider
    {
        /// <summary>
        /// Constructs an IQbservable&gt;TResult&lt; object that can evaluate the query represented by a specified expression tree.
        /// </summary>
        /// <typeparam name="TResult">The type of the elements of the System.Reactive.Linq.IQbservable&lt;T&gt; that is returned.</typeparam>
        /// <param name="expression">Expression tree representing the query.</param>
        /// <returns>IQbservable object that can evaluate the given query expression.</returns>
        IQbservable<TResult> CreateQuery<TResult>(Expression expression);
    }
}
#endif