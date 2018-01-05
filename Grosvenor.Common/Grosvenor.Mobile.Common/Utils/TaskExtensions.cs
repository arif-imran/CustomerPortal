// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskExtensions.cs" company="">
//   
// </copyright>
// <summary>
//   The task extensions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Grosvenor.Mobile.Common.Utils
{
    using System.Threading.Tasks;

    /// <summary>The task extensions.</summary>
    public static class TaskExtensions
    {
        /// <summary>The forget.</summary>
        /// <param name="task">The task.</param>
        /// <param name="setContinueAwaitFalse">The set continue await false.</param>
        public static void Forget(this Task task, bool setContinueAwaitFalse = true)
        {
            if (setContinueAwaitFalse)
            {
                task.ConfigureAwait(false);
            }
        }
    }
}