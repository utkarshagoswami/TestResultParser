﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Agent.Plugins.Log.TestResultParser.Parser
{
    public enum JasmineParserStates
    {
        ExpectingTestRunStart,
        ExpectingTestResults,
        ExpectingTestRunSummary
    }
}
