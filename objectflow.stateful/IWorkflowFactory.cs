﻿using System;
namespace Rainbow.ObjectFlow.Stateful
{
    /// <summary>
    /// Interface required for a factory to create a workflow and process an object through 
    /// it. An IoC container can be easily used to get the correct workflow for a given object.
    /// </summary>
    /// <example>
    /// // This will create the right workflow and process the file through it
    /// Container.Resolve&lt;IWorkflow&lt;SiteVisit&gt;&gt;().Process(siteVisit);
    /// </example>
    /// <typeparam name="T"></typeparam>
    public interface IWorkflowFactory<T>
    {
        /// <summary>
        /// Creates a workflow with the correct security &amp; error handling constraints and 
        /// processes the object through the correct portion and returns the result.
        /// </summary>
        /// <param name="initializer">object to be processed</param>
        /// <returns></returns>
        T Process(T initializer);
    }
}
