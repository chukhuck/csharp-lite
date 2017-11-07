﻿using Gx.Common;
using Gx.Conclusion;
using Gx.Source;
using Gx.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gedcomx.Api.Lite.Tests
{
	public static class TestBacking
	{
		public const string AppName = "Gedcomx.Api.Lite.Tests";
		public const string AppVersion = "1.0.0";

		public static Person GetPersonForDeepCompare()
		{
			return new Person()
			{
				Living = false,
				Gender = new Gender()
				{
					KnownType = Gx.Types.GenderType.Male,
					Fields = new List<Gx.Records.Field>(),
					Sources = new List<Gx.Source.SourceReference>(),
					Notes = new List<Gx.Common.Note>(),
					Links = new List<Gx.Links.Link>(),
					ExtensionElementsXml = new List<object>(),
				},
				Names = new List<Name>()
				{
					new Name()
					{
						KnownType = Gx.Types.NameType.BirthName,
						NameForms = new List<NameForm>()
						{
							new NameForm()
							{
								FullText = "GedcomX User",
								Parts = new List<NamePart>()
								{
									new NamePart()
									{
										KnownType = Gx.Types.NamePartType.Given,
										Value = "GedcomX",
										ExtensionElementsXml = new List<object>(),
										Fields = new List<Gx.Records.Field>(),
										Qualifiers = new List<Gx.Common.Qualifier>(),
									},
									new NamePart()
									{
										KnownType = Gx.Types.NamePartType.Surname,
										Value = "User",
										ExtensionElementsXml = new List<object>(),
										Fields = new List<Gx.Records.Field>(),
										Qualifiers = new List<Gx.Common.Qualifier>(),
									},
								},
								ExtensionElementsXml = new List<object>(),
								Fields = new List<Gx.Records.Field>(),
							},
							new NameForm()
							{
								FullText = "GedcomX2 User",
								Parts = new List<NamePart>()
								{
									new NamePart()
									{
										KnownType = Gx.Types.NamePartType.Given,
										Value = "GedcomX2",
										ExtensionElementsXml = new List<object>(),
										Fields = new List<Gx.Records.Field>(),
										Qualifiers = new List<Gx.Common.Qualifier>(),
									},
									new NamePart()
									{
										KnownType = Gx.Types.NamePartType.Surname,
										Value = "User",
										ExtensionElementsXml = new List<object>(),
										Fields = new List<Gx.Records.Field>(),
										Qualifiers = new List<Gx.Common.Qualifier>(),
									},
								},
								ExtensionElementsXml = new List<object>(),
								Fields = new List<Gx.Records.Field>(),
							},
						},
						Preferred = true,
						Sources = new List<Gx.Source.SourceReference>(),
						Notes = new List<Gx.Common.Note>(),
						Links = new List<Gx.Links.Link>(),
						ExtensionElementsXml = new List<object>(),
					},
				},
				Facts = new List<Fact>()
				{
					new Fact()
					{
						KnownType = Gx.Types.FactType.Birth,
						Date = new DateInfo()
						{
							Original = "June 1800",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Place = new PlaceReference()
						{
							Original = "Provo, Utah, Utah, United States",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Qualifiers = new List<Gx.Common.Qualifier>(),
						Fields = new List<Gx.Records.Field>(),
						Sources = new List<Gx.Source.SourceReference>(),
						Notes = new List<Gx.Common.Note>(),
						Links = new List<Gx.Links.Link>(),
						ExtensionElementsXml = new List<object>(),
					},
					new Fact()
					{
						KnownType = Gx.Types.FactType.Christening,
						Date = new DateInfo()
						{
							Original = "1802",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Place = new PlaceReference()
						{
							Original = "American Fork, Utah, Utah, United States",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Qualifiers = new List<Gx.Common.Qualifier>(),
						Fields = new List<Gx.Records.Field>(),
						Sources = new List<Gx.Source.SourceReference>(),
						Notes = new List<Gx.Common.Note>(),
						Links = new List<Gx.Links.Link>(),
						ExtensionElementsXml = new List<object>(),
					},
					new Fact()
					{
						KnownType = Gx.Types.FactType.Residence,
						Date = new DateInfo()
						{
							Original = "4 Jan 1896",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Place = new PlaceReference()
						{
							Original = "Provo, Utah, Utah, United States",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Qualifiers = new List<Gx.Common.Qualifier>(),
						Fields = new List<Gx.Records.Field>(),
						Sources = new List<Gx.Source.SourceReference>(),
						Notes = new List<Gx.Common.Note>(),
						Links = new List<Gx.Links.Link>(),
						ExtensionElementsXml = new List<object>(),
					},
					new Fact()
					{
						KnownType = Gx.Types.FactType.Death,
						Date = new DateInfo()
						{
							Original = "July 14, 1900",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Place = new PlaceReference()
						{
							Original = "Provo, Utah, Utah, United States",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Qualifiers = new List<Gx.Common.Qualifier>(),
						Fields = new List<Gx.Records.Field>(),
						Sources = new List<Gx.Source.SourceReference>(),
						Notes = new List<Gx.Common.Note>(),
						Links = new List<Gx.Links.Link>(),
						ExtensionElementsXml = new List<object>(),
					},
					new Fact()
					{
						KnownType = Gx.Types.FactType.Burial,
						Date = new DateInfo()
						{
							Original = "1900",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Place = new PlaceReference()
						{
							Original = "Sandy, Salt Lake, Utah, United States",
							NormalizedExtensions = new List<Gx.Common.TextValue>(),
							Fields = new List<Gx.Records.Field>(),
							ExtensionElementsXml = new List<object>(),
						},
						Qualifiers = new List<Gx.Common.Qualifier>(),
						Fields = new List<Gx.Records.Field>(),
						Sources = new List<Gx.Source.SourceReference>(),
						Notes = new List<Gx.Common.Note>(),
						Links = new List<Gx.Links.Link>(),
						ExtensionElementsXml = new List<object>(),
					}
				},
				ExtensionElementsXml = new List<object>(),
				Fields = new List<Gx.Records.Field>(),
				Evidence = new List<Gx.Common.EvidenceReference>(),
				Media = new List<Gx.Source.SourceReference>(),
				Identifiers = new List<Gx.Conclusion.Identifier>(),
				Sources = new List<Gx.Source.SourceReference>(),
				Notes = new List<Gx.Common.Note>(),
				Links = new List<Gx.Links.Link>(),
				DiscussionReferences = new List<DiscussionReference>(),
			};
		}

		public static Person GetCreateMalePerson()
		{
			return new Person()
				.SetLiving(false)
				.SetGender(new Gender().SetType(GenderType.Male))
				.SetName(new Name()
					.SetType(NameType.BirthName)
					.SetNameForm(new NameForm()
						.SetFullText("GedcomX User")
						.SetPart(new NamePart(NamePartType.Given, "GedcomX"))
						.SetPart(new NamePart(NamePartType.Surname, "User")))
					.SetNameForm(new NameForm()
						.SetFullText("GedcomX2 User")
						.SetPart(new NamePart(NamePartType.Given, "GedcomX2"))
						.SetPart(new NamePart(NamePartType.Surname, "User")))
					.SetPreferred(true))
				.SetFact(new Fact()
					.SetType(FactType.Birth)
					.SetDate(new DateInfo().SetOriginal("June 1800"))
					.SetPlace(new PlaceReference().SetOriginal("Provo, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Christening)
					.SetDate(new DateInfo().SetOriginal("1802"))
					.SetPlace(new PlaceReference().SetOriginal("American Fork, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Residence)
					.SetDate(new DateInfo().SetOriginal("4 Jan 1896"))
					.SetPlace(new PlaceReference().SetOriginal("Provo, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Death)
					.SetDate(new DateInfo().SetOriginal("July 14, 1900"))
					.SetPlace(new PlaceReference().SetOriginal("Provo, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Burial)
					.SetDate(new DateInfo().SetOriginal("1900"))
					.SetPlace(new PlaceReference().SetOriginal("Sandy, Salt Lake, Utah, United States")));
		}

		public static Person GetCreateFemalePerson()
		{
			return new Person()
				.SetLiving(false)
				.SetGender(new Gender().SetType(GenderType.Female))
				.SetName(new Name()
					.SetType(NameType.BirthName)
					.SetNameForm(new NameForm()
						.SetFullText("GedcomX User")
						.SetPart(new NamePart(NamePartType.Given, "GedcomX"))
						.SetPart(new NamePart(NamePartType.Surname, "User")))
					.SetNameForm(new NameForm()
						.SetFullText("GedcomX2 User")
						.SetPart(new NamePart(NamePartType.Given, "GedcomX2"))
						.SetPart(new NamePart(NamePartType.Surname, "User")))
					.SetPreferred(true))
				.SetFact(new Fact()
					.SetType(FactType.Birth)
					.SetDate(new DateInfo().SetOriginal("June 1800"))
					.SetPlace(new PlaceReference().SetOriginal("Provo, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Christening)
					.SetDate(new DateInfo().SetOriginal("1802"))
					.SetPlace(new PlaceReference().SetOriginal("American Fork, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Residence)
					.SetDate(new DateInfo().SetOriginal("4 Jan 1896"))
					.SetPlace(new PlaceReference().SetOriginal("Provo, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Death)
					.SetDate(new DateInfo().SetOriginal("July 14, 1900"))
					.SetPlace(new PlaceReference().SetOriginal("Provo, Utah, Utah, United States")))
				.SetFact(new Fact()
					.SetType(FactType.Burial)
					.SetDate(new DateInfo().SetOriginal("1900"))
					.SetPlace(new PlaceReference().SetOriginal("Sandy, Salt Lake, Utah, United States")));
		}

		public static SourceReference GetPersonSourceReference()
		{
			return new SourceReference()
				.SetAttribution(new Attribution()
					.SetChangeMessage("Family is at the same address found in other sources associated with this family.  Names are a good match.  Estimated births are reasonable."))
					.SetDescriptionRef("https://sandbox.familysearch.org/platform/sources/descriptions/MMH1-PNF");
		}

		public static Person GetCreatePersonConclusion(string personId)
		{
			return new Person()
			{
				Id = personId,
				Facts = new List<Fact>()
				{
					new Fact()
					{
						Attribution = new Attribution()
						{
							ChangeMessage = "Change message",
						},
						KnownType = Gx.Types.FactType.Birth,
						Date = new DateInfo()
						{
							Original = "3 Apr 1836",
							Formal = "+1836",
						},
						Place = new PlaceReference()
						{
							Original = "Moscow, Russia",
						},
					}
				}
			};
		}

		public static Person GetCreateDiscussionReference(string personId)
		{
			return new Person()
			{
				Id = personId,
				Attribution = new Attribution()
				{
					ChangeMessage = "Change message",
				},
				// TODO: discussion-references
			};
		}

		public static Note GetCreateNote()
		{
			return new Note()
				.SetSubject("Sample")
				.SetText("Sample note text " + DateTime.Now.Ticks)
				.SetAttribution(new Attribution()
					.SetContributor(new ResourceReference("https://api.familysearch.org/platform/users/agents/MM6M-8QJ").SetResourceId("MM6M-8QJ")));
		}

		public static Fact GetBirthFact()
		{
			return new Fact()
			{
				Attribution = new Attribution()
				{
					ChangeMessage = "Change message",
				},
				KnownType = Gx.Types.FactType.Birth,
				Date = new DateInfo()
				{
					Original = "3 Apr 1836",
					Formal = "+1836",
				},
				Place = new PlaceReference()
				{
					Original = "Moscow, Russia",
				},
			};
		}

		public static Fact GetCustomFact()
		{
			return new Fact()
			{
				Attribution = new Attribution()
				{
					ChangeMessage = "Change message",
				},
				Type = "data:,Eagle%20Scout",
				Qualifiers = new List<Qualifier>()
				{
					new Qualifier()
					{
						Name = "http://www.familysearch.org/v1/Event",
						Value = bool.FalseString.ToLower(),
					},
				},
			};
		}

		public static Gx.Gedcomx GetCreatePersonLifeSketch(string personId)
		{
			return new Gx.Gedcomx()
			{
				Persons = new List<Person>()
				{
					new Person()
					{
						Id = personId,
						Facts = new List<Fact>()
						{
							new Fact()
							{
								Attribution = new Attribution()
								{
									ChangeMessage = "...change message...",
								},
								Type = "http://www.familysearch.org/v1/LifeSketch",
								Value = "What a long and colorful life this person had!\nDetails are numerous and humorous.",
							},
						},
					},
				},
			};
		}

		public static Gx.Gedcomx GetUpdatePersonLifeSketch(string personId, string factId)
		{
			var result = GetCreatePersonLifeSketch(personId);

			result.Persons[0].Facts[0].Id = factId;

			return result;
		}

		public static string GetFactId(Person person, string factType)
		{
			string result = null;

			if (person != null && person.Facts != null)
			{
				result = person.Facts.Where(x => x.Type == factType).Select(x => x.Id).FirstOrDefault();
			}

			return result;
		}

		public static Fact GetMarriageFact()
		{
			return new Fact()
			{
				Attribution = new Attribution()
				{
					ChangeMessage = "Change message",
				},
				KnownType = Gx.Types.FactType.Marriage,
				Date = new DateInfo()
				{
					Original = "3 Apr 1930",
					Formal = "+1930",
				},
				Place = new PlaceReference()
				{
					Original = "Moscow, Russia",
				},
			};
		}

		public static Relationship GetCreateInvalidRelationship()
		{
			return (Relationship)new Relationship().SetLink("relationship", new Uri("https://sandbox.familysearch.org/platform/tree/couple-relationships/XXX-XXXX"));
		}

		public static Fact GetBiologicalParentFact()
		{
			return new Fact()
			{
				Attribution = new Attribution()
				{
					ChangeMessage = "Change message",
				},
				KnownType = Gx.Types.FactType.BiologicalParent,
			};
		}

		public static Name GetCreateName(String name, NameType type, bool preferred)
		{
			var nameParts = GetNameParts(name);
			return new Name()
			{
				KnownType = type,
				NameForms = new List<NameForm>()
				{
					new NameForm()
					{
						FullText = name,
						Parts = nameParts,
					},
				},
				Preferred = preferred,
			};
		}

		public static List<NamePart> GetNameParts(String name)
		{
			var result = new List<NamePart>();
			var parts = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var part in parts)
			{
				if (result.Count < parts.Length - 1)
				{
					result.Add(new NamePart() { KnownType = NamePartType.Given, Value = part });
				}
				else
				{
					result.Add(new NamePart() { KnownType = NamePartType.Surname, Value = part });
				}
			}

			return result;
		}

		public static SourceDescription GetCreateSourceDescription()
		{
			return new SourceDescription()
				.SetCitation("\"United States Census, 1900.\" database and digital images, FamilySearch (https://www.familysearch.org/: accessed 17 Mar 2012), Ethel Hollivet, 1900; citing United States Census Office, Washington, D.C., 1900 Population Census Schedules, Los Angeles, California, population schedule, Los Angeles Ward 6, Enumeration District 58, p. 20B, dwelling 470, family 501, FHL microfilm 1,240,090; citing NARA microfilm publication T623, roll 90.")
				.SetTitle("1900 US Census, Ethel Hollivet")
				.SetNote("Ethel Hollivet (line 75) with husband Albert Hollivet (line 74); also in the dwelling: step-father Joseph E Watkins (line 72), mother Lina Watkins (line 73), and grandmother -- Lina's mother -- Mary Sasnett (line 76).  Albert's mother and brother also appear on this page -- Emma Hollivet (line 68), and Eddie (line 69).")
				.SetAttribution(new Attribution()
					.SetContributor(new ResourceReference("https://api.familysearch.org/platform/users/agents/MM6M-8QJ").SetResourceId("MM6M-8QJ"))
					.SetModified(DateTime.Now)
					.SetChangeMessage("This is the change message"));
		}

		public static SourceDescription GetCreateUserSourceDescription(string memoryUri)
		{
			return new SourceDescription()
			{
				About = memoryUri,
				Titles = new List<TextValue>()
				{
					new TextValue()
					{
						Value = "Grandpa's Birth Certificate",
					}
				},
				Notes = new List<Note>()
				{
					new Note()
					{
						Text = "This is an image of Grandpa's birth certificate.",
					}
				}
			};
		}

		public static Gx.Gedcomx GetGedcomxObjectForDeepCompare()
		{
			return new Gx.Gedcomx()
			{
				Persons = new List<Gx.Conclusion.Person>() {
					TestBacking.GetPersonForDeepCompare()
				},
				Relationships = new List<Gx.Conclusion.Relationship>(),
				SourceDescriptions = new List<Gx.Source.SourceDescription>(),
				Agents = new List<Gx.Agent.Agent>(),
				Events = new List<Gx.Conclusion.Event>(),
				Places = new List<Gx.Conclusion.PlaceDescription>(),
				Documents = new List<Gx.Conclusion.Document>(),
				Collections = new List<Gx.Records.Collection>(),
				Fields = new List<Gx.Records.Field>(),
				RecordDescriptors = new List<Gx.Records.RecordDescriptor>(),
				Links = new List<Gx.Links.Link>(),
				ExtensionElementsXml = new List<object>(),
			};
		}
	}
}
