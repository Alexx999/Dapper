﻿using System;

namespace Dapper
{
    /// <summary>
    /// Additional state flags that control command behaviour
    /// </summary>
    [Flags]
    public enum CommandFlags
    {
        /// <summary>
        /// No additional flags
        /// </summary>
        None = 0,
        /// <summary>
        /// Should data be buffered before returning?
        /// </summary>
        Buffered = 1,
        /// <summary>
        /// Can async queries be pipelined?
        /// </summary>
        Pipelined = 2,
        /// <summary>
        /// Should the plan cache be bypassed?
        /// </summary>
        NoCache = 4,
        /// <summary>
        /// Should the command object be reused?
        /// </summary>
        ReuseCommand = 8,
        /// <summary>
        /// Should the IDataReader.GetFieldType be treated as unstable?
        /// </summary>
        UnstableGetType = 16,
    }
}
