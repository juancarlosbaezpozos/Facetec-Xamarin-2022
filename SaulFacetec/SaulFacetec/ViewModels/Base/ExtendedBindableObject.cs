using System;
using System.Linq.Expressions;
using System.Reflection;
using Xamarin.Forms;

namespace SaulFacetec.ViewModels.Base
{
    /// <summary>
    /// Class ExtendedBindableObject.
    /// Implements the <see cref="Xamarin.Forms.BindableObject" />
    /// </summary>
    /// <seealso cref="Xamarin.Forms.BindableObject" />
    public abstract class ExtendedBindableObject : BindableObject
    {
        /// <summary>
        /// Raises the property changed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property">The property.</param>
        public void RaisePropertyChanged<T>(Expression<Func<T>> property)
        {
            var name = GetMemberInfo(property).Name;
            OnPropertyChanged(name);
        }

        /// <summary>
        /// Gets the member information.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>MemberInfo.</returns>
        private MemberInfo GetMemberInfo(Expression expression)
        {
            MemberExpression operand;
            var lambdaExpression = (LambdaExpression)expression;
            if (lambdaExpression.Body is UnaryExpression body)
            {
                operand = (MemberExpression)body.Operand;
            }
            else
            {
                operand = (MemberExpression)lambdaExpression.Body;
            }
            return operand.Member;
        }
    }
}
