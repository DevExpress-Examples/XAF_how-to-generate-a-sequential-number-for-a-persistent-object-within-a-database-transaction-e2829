﻿Imports System
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports System.Collections.Generic
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports GenerateUserFriendlyId.Module.BusinessObjects

Namespace Demo.Module.BusinessObjects
	<DefaultClassOptions>
	<DefaultProperty("FullName")>
	<ImageName("BO_Person")>
	Public Class Contact
		Inherits UserFriendlyIdPersistentObject

		<PersistentAlias("Concat('C',PadLeft(ToStr(SequentialNumber),6,'0'))")>
		Public ReadOnly Property ContactId() As String
			Get
				Return Convert.ToString(EvaluateAlias("ContactId"))
			End Get
		End Property

'INSTANT VB NOTE: The field firstName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private firstName_Renamed As String
'INSTANT VB NOTE: The field lastName was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private lastName_Renamed As String
'INSTANT VB NOTE: The field sex was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private sex_Renamed As Sex
'INSTANT VB NOTE: The field age was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private age_Renamed As Integer
'INSTANT VB NOTE: The field address was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private address_Renamed As Address
		Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("FirstName", firstName_Renamed, value)
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("LastName", lastName_Renamed, value)
			End Set
		End Property
		Public Property Age() As Integer
			Get
				Return age_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Age", age_Renamed, value)
			End Set
		End Property
		Public Property Sex() As Sex
			Get
				Return sex_Renamed
			End Get
			Set(ByVal value As Sex)
				SetPropertyValue("Sex", sex_Renamed, value)
			End Set
		End Property
		<Association>
		Public Property Address() As Address
			Get
				Return address_Renamed
			End Get
			Set(ByVal value As Address)
				SetPropertyValue("Address", address_Renamed, value)
			End Set
		End Property
		<PersistentAlias("concat(FirstName, LastName)")>
		Public ReadOnly Property FullName() As String
			Get
				Return ObjectFormatter.Format("{FirstName} {LastName}", Me, EmptyEntriesMode.RemoveDelimiterWhenEntryIsEmpty)
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
	Public Enum Sex
		Male
		Female
	End Enum
End Namespace
