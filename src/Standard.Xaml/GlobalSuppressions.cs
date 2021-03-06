// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

#region Microsoft.Design Suppressions
[assembly: SuppressMessage("Microsoft.Design", "CA1064:Exceptions should be public", Justification = "Exception is internal only", Scope = "type", Target = "~T:MS.Internal.Xaml.Parser.GenericTypeNameParser.TypeNameParserException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:Implement standard exception constructors", Justification = "Exception is internal only", Scope = "type", Target = "~T:MS.Internal.Xaml.Parser.GenericTypeNameParser.TypeNameParserException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1028:EnumStorageShouldBeInt32", Scope = "type", Target = "Standard.Xaml.Schema.XamlCollectionKind", Justification = "Our measurements showed this type provided improved spacial complexity.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1028:EnumStorageShouldBeInt32", Scope = "type", Target = "Standard.Xaml.XamlNodeType", Justification = "Our measurements showed this type provided improved spacial complexity.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1036:OverrideMethodsOnComparableTypes", Scope = "type", Target = "Standard.Xaml.Schema.ReferenceEqualityTuple`2<T1,T2>", Justification = "Internal Only")]
[assembly: SuppressMessage("Microsoft.Design", "CA1036:OverrideMethodsOnComparableTypes", Scope = "type", Target = "Standard.Xaml.Schema.ReferenceEqualityTuple`3<T1,T2,T3>", Justification = "Internal Only")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification = "Not changing public API surface for .NET Core 3 release", Scope = "member", Target = "~M:Standard.Xaml.XamlWriter.System#IDisposable#Dispose")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:Do not catch general exception types", Justification = "Don't want render thread to crash", Scope = "member", Target = "~M:Standard.Xaml.XamlBackgroundReader.XamlReaderThreadStart(System.Object)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:Do not catch general exception types", Justification = "Finalizers shouldn't throw", Scope = "member", Target = "~M:Standard.Xaml.XamlSchemaContext.Finalize")]
#endregion

#region Microsoft.Performance suppressions
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "MS.Internal.Xaml.Context.ObjectWriterFrame")]

// Need this public Ctor Override that takes an InnerExcepetion.
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.XamlParseException.#.ctor(MS.Internal.Xaml.Context.XamlParserContext,System.String,System.Exception)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.EventTrace.#EasyTraceEvent(MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Event)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.EventTrace.#EasyTraceEvent(MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Event,System.Object)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.EventTrace.#EasyTraceEvent(MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Event,System.Object,System.Object)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.EventTrace.#EasyTraceEvent(MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Event,System.Object,System.Object,System.Object)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.EventTrace.#EasyTraceEvent(MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Level,MS.Internal.Xaml.EventTrace+Event)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.EventTrace.#EasyTraceEvent(MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Level,MS.Internal.Xaml.EventTrace+Event,System.Object)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.EventTrace.#EasyTraceEvent(MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Level,MS.Internal.Xaml.EventTrace+Event,System.Object,System.Object)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.TraceProvider.#get_Keywords()", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.TraceProvider.#get_Level()", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.TraceProvider.#get_MatchAllKeywords()", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.TraceProvider.#TraceEvent(MS.Internal.Xaml.EventTrace+Event,MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Level)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.TraceProvider.#TraceEvent(MS.Internal.Xaml.EventTrace+Event,MS.Internal.Xaml.EventTrace+Keyword,MS.Internal.Xaml.EventTrace+Level,System.Object)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.Context.ObjectWriterContext.#get_ParentInstanceRegisteredName()", Justification = "We need the setter, and write-only properties are bad practice")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Internal.Xaml.Context.ObjectWriterContext.#get_ParentKey()", Justification = "We need the setter, and write-only properties are bad practice")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "MS.Win32.ClassicEtw.#GetTraceLoggerHandle(MS.Win32.ClassicEtw+WNODE_HEADER*)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.ReflectionHelper.#GetAlreadyLoadedAssembly(System.String)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.ReflectionHelper.#GetCustomAttributeData(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>,System.Type,System.Type&,System.Boolean,System.Boolean)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.ReflectionHelper.#GetCustomAttributeData(System.Reflection.MemberInfo,System.Type,System.Type&)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.ReflectionHelper.#GetTypeConverterAttributeData(System.Reflection.MemberInfo,System.Type&)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.ReflectionHelper.#IsInternalType(System.Type)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.ReflectionHelper.#ResetCacheForAssembly(System.String)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.SR.#get_ResourceManager()", Justification = "Auto-generated")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.XmlCompatibilityReader.#.ctor(System.Xml.XmlReader,System.Collections.Generic.IEnumerable`1<System.String>)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.XmlCompatibilityReader.#.ctor(System.Xml.XmlReader,Standard.Xaml.IsXmlNamespaceSupportedCallback,System.Collections.Generic.IEnumerable`1<System.String>)", Justification = "Shared source file")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.XmlCompatibilityReader.#get_Encoding()", Justification = "Shared source file")]

// This is a debug-only method, we should mark it as Conditional("DEBUG")
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.XamlNode.#IsEof_Helper(Standard.Xaml.XamlNodeType,System.Object)", Justification = "Fix doesn't meet Ask Mode bar")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Standard.Xaml.XamlObjectWriter.#get_ObjectWriterContext()", Justification = "Fix doesn't meet Ask Mode bar - Bug 773900")]

// New since v4 RTM:

//this is used by subclasses, bad FxCop detection
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "Standard.Xaml.MS.Impl.FrugalObjectList`1+Compacter")]
#endregion

#region Microsoft.Naming Suppressions
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.XamlType.#IsWhitespaceSignificantCollectionCore", MessageId = "Whitespace", Justification = "Add Whitespace to the dictionary if we already shipped, and it seems good.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.XamlType.#IsWhitespaceSignificantCollection", MessageId = "Whitespace", Justification = "Add Whitespace to the dictionary if we already shipped, and it seems good.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.XamlType.#TrimSurroundingWhitespace", MessageId = "Whitespace", Justification = "Add Whitespace to the dictionary if we already shipped, and it seems good.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.XamlType.#TrimSurroundingWhitespaceCore", MessageId = "Whitespace", Justification = "Add Whitespace to the dictionary if we already shipped, and it seems good.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.Schema.XaslType.#IsWhitespaceSignificantCollection", MessageId = "Whitespace", Justification = "Add Whitespace to the dictionary if we already shipped, and it seems good.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.Schema.XaslType.#TrimSurroundingWhitespace", MessageId = "Whitespace", Justification = "Add Whitespace to the dictionary if we already shipped, and it seems good.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Standard.Xaml.XamlReader.#IsEof", MessageId = "Eof", Justification = "Review Eof")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Standard.Xaml.XamlNodeQueue", Justification = "This is unnecessarily limiting.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Standard.Windows.Markup.PropertyDefinition.#Type", Justification = "Makes sense for our problem domain.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Standard.Xaml.XamlMember.#Type", Justification = "Makes sense for our problem domain.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Standard.Xaml.XamlReader.#Type", Justification = "Makes sense for our problem domain.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "member", Target = "Standard.Xaml.XamlReader.#Namespace", MessageId = "Namespace", Justification = "Works for our problem domain.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.XamlType.#LookupIsWhitespaceSignificantCollection()", MessageId = "Whitespace", Justification = "Back compat.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Scope = "member", Target = "Standard.Xaml.XamlType.#LookupTrimSurroundingWhitespace()", MessageId = "Whitespace", Justification = "Back compat.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubClass", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#SubClass", Justification = "Needs to match the capitalization used in XAML syntax.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace", Scope = "type", Target = "Standard.Windows.Markup.TrimSurroundingWhitespaceAttribute", Justification = "Kept for compatibility.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace", Scope = "type", Target = "Standard.Windows.Markup.WhitespaceSignificantCollectionAttribute", Justification = "Kept for compatibility.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Standard.Windows.Markup.ArrayExtension.#Type", Justification = "Kept for compatibility.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Standard.Windows.Markup.TypeExtension.#Type", Justification = "Kept for compatibility.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "nameSpace", Scope = "member", Target = "Standard.Windows.Markup.RootNamespaceAttribute.#.ctor(System.String)", Justification = "Inherited from Base.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Standard.Windows.Markup.NameScopePropertyAttribute.#Type", Justification = "Kept for compatibility.")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Uid", Scope = "type", Target = "Standard.Windows.Markup.UidPropertyAttribute")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Uid", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Uid")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Namescope", Scope = "member", Target = "Standard.Xaml.XamlObjectWriterSettings.#RegisterNamesOnExternalNamescope")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Uids", Scope = "member", Target = "Standard.Xaml.XamlReaderSettings.#IgnoreUidsOnPropertyElements")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Arity", Scope = "member", Target = "Standard.Xaml.XamlSchemaContext.#SupportMarkupExtensionsWithDuplicateArity")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Arity", Scope = "member", Target = "Standard.Xaml.XamlSchemaContextSettings.#SupportMarkupExtensionsWithDuplicateArity")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", MessageId = "Arity", Scope = "resource", Target = "ExceptionStringTable.resources")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#String")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Double")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Int32")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Object")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Char")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Single")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Int16")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Int64")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Standard.Xaml.XamlLanguage.#Decimal")]
#endregion

#region Microsoft.Usage Suppressions
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.ThreeItemList`1.Promote(Standard.Xaml.MS.Impl.ThreeItemList`1<T>):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.ThreeItemList`1.SetCount(System.Int32):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.ThreeItemList`1.Promote(Standard.Xaml.MS.Impl.FrugalListBase`1<T>):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.ArrayItemList`1.Promote(Standard.Xaml.MS.Impl.SixItemList`1<T>):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.ArrayItemList`1.SetCount(System.Int32):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.SingleItemList`1.SetCount(System.Int32):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.SixItemList`1.Promote(Standard.Xaml.MS.Impl.SixItemList`1<T>):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.SixItemList`1.Promote(Standard.Xaml.MS.Impl.ThreeItemList`1<T>):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.SixItemList`1.SetCount(System.Int32):System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Standard.Xaml.MS.Impl.SixItemList`1.Promote(Standard.Xaml.MS.Impl.FrugalListBase`1<T>):System.Void")]
#endregion

#region Microsoft.Reliablity Suppressions
[module: SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", Scope = "member", Target = "Standard.Xaml.Schema.ClrNamespace.#ParseClrNamespaceUri(System.String)", MessageId = "System.Reflection.Assembly.LoadWithPartialName", Justification = "Back compat.")]
[module: SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFile", Scope = "member", Target = "Standard.Xaml.ReflectionHelper.#LoadAssemblyHelper(System.String,System.String)")]
[module: SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadWithPartialName", Scope = "member", Target = "Standard.Xaml.XamlSchemaContext.#ResolveAssembly(System.String)", Justification = "Need to support load of assemblies from GAC by short name.")]
#endregion