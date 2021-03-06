﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Agent.Plugins.Log.TestResultParser.Contracts;

namespace Agent.Plugins.Log.TestResultParser.Parser
{
    public class JestParserStateContext : AbstractParserStateContext
    {
        public JestParserStateContext(TestRun testRun) : base(testRun)
        {
            Initialize(testRun);
        }

        /// <summary>
        /// Used to identify if a run had the --verbose option enabled
        /// </summary>
        public bool VerboseOptionEnabled { get; set; }

        /// <summary>
        /// This is used to identify that the failed tests summary indicator has been encountered
        /// All the failed test cases are reported after this again hence we use this to ignore them
        /// </summary>
        public bool FailedTestsSummaryIndicatorEncountered { get; set; }

        /// <summary>
        /// Current stack trace index. Used to insert the stack trace to the appropriate failed test case later in the stack traces state.
        /// </summary>
        public int CurrentStackTraceIndex { get; set; }

        /// <summary>
        /// Initializes all the values to their defaults
        /// </summary>
        public new void Initialize(TestRun testRun)
        {
            base.Initialize(testRun);
            LinesWithinWhichMatchIsExpected = -1;
            CurrentStackTraceIndex = -1;
            NextExpectedMatch = null;
            VerboseOptionEnabled = false;
            FailedTestsSummaryIndicatorEncountered = false;
        }
    }
}
