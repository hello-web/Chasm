#region License

// Copyright (c) K2 Workflow (SourceCode Technology Holdings Inc.). All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

#endregion

using Moq;
using SourceCode.Chasm.IO;
using SourceCode.Chasm.Tests.Helpers;
using System;
using System.Runtime.Serialization;
using Xunit;

namespace SourceCode.Chasm.Tests.IO
{
    public static class ChasmConcurrencyExceptionTests
    {
        #region Methods

        [Trait("Type", "Unit")]
        [Fact(DisplayName = nameof(ChasmConcurrencyException_Constructor_Empty))]
        public static void ChasmConcurrencyException_Constructor_Empty()
        {
            // Arrange & Action
            var actual = new ChasmConcurrencyException();

            // Assert
            Assert.NotNull(actual);
        }

        [Trait("Type", "Unit")]
        [Fact(DisplayName = nameof(ChasmConcurrencyException_Constructor_String))]
        public static void ChasmConcurrencyException_Constructor_String()
        {
            // Arrange
            var expectedMessage = RandomHelper.String;

            // Action
            var actual = new ChasmConcurrencyException(expectedMessage);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expectedMessage, actual.Message);
        }

        [Trait("Type", "Unit")]
        [Fact(DisplayName = nameof(ChasmConcurrencyException_Constructor_String_Exception))]
        public static void ChasmConcurrencyException_Constructor_String_Exception()
        {
            // Arrange
            var expectedInnerException = new Exception(RandomHelper.String);
            var expectedMessage = RandomHelper.String;

            // Action
            var actual = new ChasmConcurrencyException(expectedMessage, expectedInnerException);

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expectedMessage, actual.Message);
            Assert.Equal(expectedInnerException, actual.InnerException);
        }

        [Trait("Type", "Unit")]
        [Fact(DisplayName = nameof(ChasmConcurrencyException_GetObjectData))]
        public static void ChasmConcurrencyException_GetObjectData()
        {
            // Arrange
            var mockFormatterConverter = new Mock<IFormatterConverter>();
            var mockSerializationInfo = new SerializationInfo(typeof(ChasmConcurrencyException), mockFormatterConverter.Object);
            var mockStreamingContext = new StreamingContext();

            // Action
            var actual = new ChasmConcurrencyException();
            actual.GetObjectData(mockSerializationInfo, mockStreamingContext);
        }

        #endregion
    }
}
