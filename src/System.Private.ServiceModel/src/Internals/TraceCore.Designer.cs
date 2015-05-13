//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Runtime
{
    using System.Runtime.Diagnostics;
    using System.Security;
    using System.ServiceModel;

    internal partial class TraceCore
    {
        
        static System.Resources.ResourceManager resourceManager;
        
        static System.Globalization.CultureInfo resourceCulture;
        

        static object syncLock = new object();
        
        // Double-checked locking pattern requires volatile for read/write synchronization
        
        private TraceCore()
        {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification="This is an auto-generated code, some ETW/TraceSource mixed code would use it.")]
        static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceManager, null))
                {
                    resourceManager = new System.Resources.ResourceManager("System.Runtime.TraceCore", typeof(TraceCore).Assembly());
                }
                return resourceManager;
            }
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification="This template is shared across all assemblies, some of which use this accessor.")]
        internal static System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57393, Level=informational, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool AppDomainUnloadIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: AppDomain unloading. AppDomain.FriendlyName {0}, ProcessName {1}, ProcessId {2}.
        /// Event description ID=57393, Level=informational, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="appdomainName">Parameter 0 for event: AppDomain unloading. AppDomain.FriendlyName {0}, ProcessName {1}, ProcessId {2}.</param>
        /// <param name="processName">Parameter 1 for event: AppDomain unloading. AppDomain.FriendlyName {0}, ProcessName {1}, ProcessId {2}.</param>
        /// <param name="processId">Parameter 2 for event: AppDomain unloading. AppDomain.FriendlyName {0}, ProcessName {1}, ProcessId {2}.</param>
        internal static void AppDomainUnload(EtwDiagnosticTrace trace, string appdomainName, string processName, string processId)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57394, Level=informational, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool HandledExceptionIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Handling an exception.  Exception details: {0}
        /// Event description ID=57394, Level=informational, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Handling an exception.  Exception details: {0}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void HandledException(EtwDiagnosticTrace trace, string param0, System.Exception exception)
        {
        }
        
        
        /// <summary>
        /// Gets trace definition like: An unexpected failure occurred. Applications should not attempt to handle this error. For diagnostic purposes, this English message is associated with the failure: {0}.
        /// Event description ID=57395, Level=error, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: An unexpected failure occurred. Applications should not attempt to handle this error. For diagnostic purposes, this English message is associated with the failure: {0}.</param>
        internal static void ShipAssertExceptionMessage(EtwDiagnosticTrace trace, string param0)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57396, Level=warning, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool ThrowingExceptionIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Throwing an exception. Source: {0}. Exception details: {1}
        /// Event description ID=57396, Level=warning, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="param1">Parameter 1 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void ThrowingException(EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57397, Level=critical, Channel=Operational
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool UnhandledExceptionIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Unhandled exception.  Exception details: {0}
        /// Event description ID=57397, Level=critical, Channel=Operational
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Unhandled exception.  Exception details: {0}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void UnhandledException(EtwDiagnosticTrace trace, string param0, System.Exception exception)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57399, Level=critical, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool TraceCodeEventLogCriticalIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Wrote to the EventLog.
        /// Event description ID=57399, Level=critical, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="traceRecord">Extended data (TraceRecord) for the event</param>
        internal static void TraceCodeEventLogCritical(EtwDiagnosticTrace trace, TraceRecord traceRecord)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57400, Level=error, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool TraceCodeEventLogErrorIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Wrote to the EventLog.
        /// Event description ID=57400, Level=error, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="traceRecord">Extended data (TraceRecord) for the event</param>
        internal static void TraceCodeEventLogError(EtwDiagnosticTrace trace, TraceRecord traceRecord)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57401, Level=informational, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool TraceCodeEventLogInfoIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
     }
        
        /// <summary>
        /// Gets trace definition like: Wrote to the EventLog.
        /// Event description ID=57401, Level=informational, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="traceRecord">Extended data (TraceRecord) for the event</param>
        internal static void TraceCodeEventLogInfo(EtwDiagnosticTrace trace, TraceRecord traceRecord)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57402, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool TraceCodeEventLogVerboseIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Wrote to the EventLog.
        /// Event description ID=57402, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="traceRecord">Extended data (TraceRecord) for the event</param>
        internal static void TraceCodeEventLogVerbose(EtwDiagnosticTrace trace, TraceRecord traceRecord)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57403, Level=warning, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool TraceCodeEventLogWarningIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Wrote to the EventLog.
        /// Event description ID=57403, Level=warning, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="traceRecord">Extended data (TraceRecord) for the event</param>
        internal static void TraceCodeEventLogWarning(EtwDiagnosticTrace trace, TraceRecord traceRecord)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57404, Level=warning, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool HandledExceptionWarningIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Handling an exception. Exception details: {0}
        /// Event description ID=57404, Level=warning, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Handling an exception. Exception details: {0}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void HandledExceptionWarning(EtwDiagnosticTrace trace, string param0, System.Exception exception)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=131, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool BufferPoolAllocationIsEnabled(EtwDiagnosticTrace trace)
        {
            return TraceCore.IsEtwEventEnabled(trace, 11);
        }
        
        /// <summary>
        /// Gets trace definition like: Pool allocating {0} Bytes.
        /// Event description ID=131, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="Size">Parameter 0 for event: Pool allocating {0} Bytes.</param>
        internal static void BufferPoolAllocation(EtwDiagnosticTrace trace, int Size)
        {
            TracePayload payload = trace.GetSerializedPayload(null, null, null);
            if (TraceCore.IsEtwEventEnabled(trace, 11))
            {
                TraceCore.WriteEtwEvent(trace, 11, null, Size, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=132, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool BufferPoolChangeQuotaIsEnabled(EtwDiagnosticTrace trace)
        {
            return TraceCore.IsEtwEventEnabled(trace, 12);
        }
        
        /// <summary>
        /// Gets trace definition like: BufferPool of size {0}, changing quota by {1}.
        /// Event description ID=132, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="PoolSize">Parameter 0 for event: BufferPool of size {0}, changing quota by {1}.</param>
        /// <param name="Delta">Parameter 1 for event: BufferPool of size {0}, changing quota by {1}.</param>
        internal static void BufferPoolChangeQuota(EtwDiagnosticTrace trace, int PoolSize, int Delta)
        {
            TracePayload payload = trace.GetSerializedPayload(null, null, null);
            if (TraceCore.IsEtwEventEnabled(trace, 12))
            {
                TraceCore.WriteEtwEvent(trace, 12, null, PoolSize, Delta, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=133, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool ActionItemScheduledIsEnabled(EtwDiagnosticTrace trace)
        {
            return TraceCore.IsEtwEventEnabled(trace, 13);
        }
        
        /// <summary>
        /// Gets trace definition like: IO Thread scheduler callback invoked.
        /// Event description ID=133, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventTraceActivity">The event trace activity</param>
        internal static void ActionItemScheduled(EtwDiagnosticTrace trace, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity)
        {
            TracePayload payload = trace.GetSerializedPayload(null, null, null);
            if (TraceCore.IsEtwEventEnabled(trace, 13))
            {
                TraceCore.WriteEtwEvent(trace, 13, eventTraceActivity, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=134, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool ActionItemCallbackInvokedIsEnabled(EtwDiagnosticTrace trace)
        {
            return TraceCore.IsEtwEventEnabled(trace, 14);
        }
        
        /// <summary>
        /// Gets trace definition like: IO Thread scheduler callback invoked.
        /// Event description ID=134, Level=verbose, Channel=Debug
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventTraceActivity">The event trace activity</param>
        internal static void ActionItemCallbackInvoked(EtwDiagnosticTrace trace, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity)
        {
            TracePayload payload = trace.GetSerializedPayload(null, null, null);
            if (TraceCore.IsEtwEventEnabled(trace, 14))
            {
                TraceCore.WriteEtwEvent(trace, 14, eventTraceActivity, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57405, Level=error, Channel=Operational
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool HandledExceptionErrorIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Handling an exception. Exception details: {0}
        /// Event description ID=57405, Level=error, Channel=Operational
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Handling an exception. Exception details: {0}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void HandledExceptionError(EtwDiagnosticTrace trace, string param0, System.Exception exception)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57406, Level=verbose, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool HandledExceptionVerboseIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Handling an exception  Exception details: {0}
        /// Event description ID=57406, Level=verbose, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Handling an exception  Exception details: {0}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void HandledExceptionVerbose(EtwDiagnosticTrace trace, string param0, System.Exception exception)
        {
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57408, Level=critical, Channel=Operational
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool EtwUnhandledExceptionIsEnabled(EtwDiagnosticTrace trace)
        {
            return TraceCore.IsEtwEventEnabled(trace, 17);
        }
        
        /// <summary>
        /// Gets trace definition like: Unhandled exception. Exception details: {0}
        /// Event description ID=57408, Level=critical, Channel=Operational
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Unhandled exception. Exception details: {0}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void EtwUnhandledException(EtwDiagnosticTrace trace, string param0, System.Exception exception)
        {
            TracePayload payload = trace.GetSerializedPayload(null, null, exception);
            if (TraceCore.IsEtwEventEnabled(trace, 17))
            {
                TraceCore.WriteEtwEvent(trace, 17, null, param0, payload.SerializedException, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57410, Level=warning, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool ThrowingEtwExceptionIsEnabled(EtwDiagnosticTrace trace)
        {
            return TraceCore.IsEtwEventEnabled(trace, 18);
        }
        
        /// <summary>
        /// Gets trace definition like: Throwing an exception. Source: {0}. Exception details: {1}
        /// Event description ID=57410, Level=warning, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="param1">Parameter 1 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void ThrowingEtwException(EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
        {
            TracePayload payload = trace.GetSerializedPayload(null, null, exception);
            if (TraceCore.IsEtwEventEnabled(trace, 18))
            {
                TraceCore.WriteEtwEvent(trace, 18, null, param0, param1, payload.SerializedException, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57409, Level=verbose, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool ThrowingEtwExceptionVerboseIsEnabled(EtwDiagnosticTrace trace)
        {
            return TraceCore.IsEtwEventEnabled(trace, 19);
        }
        
        /// <summary>
        /// Gets trace definition like: Throwing an exception. Source: {0}. Exception details: {1}
        /// Event description ID=57409, Level=verbose, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="param1">Parameter 1 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void ThrowingEtwExceptionVerbose(EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
        {
            TracePayload payload = trace.GetSerializedPayload(null, null, exception);
            if (TraceCore.IsEtwEventEnabled(trace, 19))
            {
                TraceCore.WriteEtwEvent(trace, 19, null, param0, param1, payload.SerializedException, payload.AppDomainFriendlyName);
            }
        }
        
        /// <summary>
        /// Check if trace definition is enabled
        /// Event description ID=57407, Level=verbose, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        internal static bool ThrowingExceptionVerboseIsEnabled(EtwDiagnosticTrace trace)
        {
            return false;
        }
        
        /// <summary>
        /// Gets trace definition like: Throwing an exception. Source: {0}. Exception details: {1}
        /// Event description ID=57407, Level=verbose, Channel=Analytic
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="param0">Parameter 0 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="param1">Parameter 1 for event: Throwing an exception. Source: {0}. Exception details: {1}</param>
        /// <param name="exception">Exception associated with the event</param>
        internal static void ThrowingExceptionVerbose(EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception)
        {
        }
        
        /// <summary>
        /// Creates the event descriptors array
        /// </summary>
        // Critical = Sets the SecurityCritical member eventDescriptors
        // Safe = We control what the event descriptors contain
        [System.Security.SecuritySafeCriticalAttribute()]
        static void CreateEventDescriptors()
        {
        }
        
        /// <summary>
        /// Ensures that the event descriptors array is initialized
        /// </summary>
        static void EnsureEventDescriptors()
        {
        }
        
        /// <summary>
        /// Check if ETW tracing is enabled for the particular event
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>
        // Critical = Accesses SecurityCritical member eventDescriptors
        // Safe = eventDescriptors is not changed
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool IsEtwEventEnabled(EtwDiagnosticTrace trace, int eventIndex)
        {
            return false;
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        /// <param name="eventParam3">A parameter of the ETW event</param>>
        /// <param name="eventParam4">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3, string eventParam4)
        {
            return false;
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        /// <param name="eventParam3">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3)
        {
            return false;
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2)
        {
            return false;
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, int eventParam1, string eventParam2)
        {
            return false;
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        /// <param name="eventParam2">A parameter of the ETW event</param>>
        /// <param name="eventParam3">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, int eventParam1, int eventParam2, string eventParam3)
        {
            return false;
        }
        
        /// <summary>
        /// Writes ETW trace event
        ///</summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>>
        /// <param name="eventParam0">A parameter of the ETW event</param>>
        /// <param name="eventParam1">A parameter of the ETW event</param>>
        // Critical = Calls SecurityCritical method EtwProvider.WriteEvent
        // Safe = We only allow setting of provider id from SecurityCritical code, access to EventDescriptors is SecurityCritical, and ETW limits buffer sizes.
        [System.Security.SecuritySafeCriticalAttribute()]
        static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1)
        {
            return false;
        }
        
        /// <summary>
        /// write a trace source into the diagnostic trace
        /// </summary>
        /// <param name="trace">The trace provider</param>
        /// <param name="eventIndex">The index of the event descriptor</param>
        /// <param name="description">The description to write</param>
        /// <param name="payload">The trace payload</param>
        // Critical = Calls SecurityCritical method EtwDiagnosticTrace.WriteTraceSource
        // Safe = We only allow setting of provider id from SecurityCritical code
        [System.Security.SecuritySafeCriticalAttribute()]
        static void WriteTraceSource(EtwDiagnosticTrace trace, int eventIndex, string description, TracePayload payload)
        {
        }
    }
}
