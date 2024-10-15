// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterDB
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E7A")]
  public class CharacterDB
  {
    [Token(Token = "0x4002C47")]
    public const string BodyPath = "CH/BODY/";
    [Token(Token = "0x4002C48")]
    public const string BodyTexturePath = "CH/BODYTEX/";
    [Token(Token = "0x4002C49")]
    public const string HeadPath = "CH/HEAD/";
    [Token(Token = "0x4002C4A")]
    public const string HairPath = "CH/HAIR/";
    [Token(Token = "0x4002C4B")]
    public const string HeadAttachmentPath = "CH/HEADOPT/";
    [Token(Token = "0x4002C4C")]
    public const string BodyAttachmentPath = "CH/BODYOPT/";
    [Token(Token = "0x4002C4D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string DatabasePath;
    [Token(Token = "0x4002C4E")]
    [FieldOffset(Offset = "0x4")]
    private static List<CharacterDB.Character> mCharacters;
    [Token(Token = "0x4002C4F")]
    [FieldOffset(Offset = "0x8")]
    private static bool mDBLoaded;

    [Token(Token = "0x6003C0B")]
    [Address(RVA = "0x10E8890", Offset = "0x10E7690", VA = "0x110E8890")]
    public static GameObject ComposeCharacter(string characterID, string jobID)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6003C0C")]
    [Address(RVA = "0x10E9C20", Offset = "0x10E8A20", VA = "0x110E9C20")]
    public static void UnloadAll()
    {
    }

    [Token(Token = "0x6003C0D")]
    [Address(RVA = "0x10E9830", Offset = "0x10E8630", VA = "0x110E9830")]
    public static void ReloadDatabase()
    {
    }

    [Token(Token = "0x6003C0E")]
    [Address(RVA = "0x10E98F0", Offset = "0x10E86F0", VA = "0x110E98F0")]
    public static CharacterDB.Character ReserveCharacter(string characterID)
    {
      return (CharacterDB.Character) null;
    }

    [Token(Token = "0x6003C0F")]
    [Address(RVA = "0x10E8B50", Offset = "0x10E7950", VA = "0x110E8B50")]
    public static CharacterDB.Character FindCharacter(string characterID)
    {
      return (CharacterDB.Character) null;
    }

    [Token(Token = "0x6003C10")]
    [Address(RVA = "0x10E8CD0", Offset = "0x10E7AD0", VA = "0x110E8CD0")]
    public static CharacterDB.Job FindCharacter(string characterID, string jobResourceID)
    {
      return (CharacterDB.Job) null;
    }

    [Token(Token = "0x6003C11")]
    [Address(RVA = "0x10E9A40", Offset = "0x10E8840", VA = "0x110E9A40")]
    private static string SerializeColor(Color32 color) => (string) null;

    [Token(Token = "0x6003C12")]
    [Address(RVA = "0x10E8E20", Offset = "0x10E7C20", VA = "0x110E8E20")]
    public static void LoadDatabase()
    {
    }

    [Token(Token = "0x6003C13")]
    [Address(RVA = "0x10E8DD0", Offset = "0x10E7BD0", VA = "0x110E8DD0")]
    private static void GetColumnsBool(string[] columns, int index, ref bool result)
    {
    }

    [Token(Token = "0x6003C14")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CharacterDB()
    {
    }

    [Token(Token = "0x6003C15")]
    [Address(RVA = "0x10E9CA0", Offset = "0x10E8AA0", VA = "0x110E9CA0")]
    static CharacterDB()
    {
    }

    [Token(Token = "0x2000E7B")]
    [Serializable]
    public class Job
    {
      [Token(Token = "0x4002C50")]
      [FieldOffset(Offset = "0x8")]
      public int HashID;
      [Token(Token = "0x4002C51")]
      [FieldOffset(Offset = "0xC")]
      public string JobID;
      [Token(Token = "0x4002C52")]
      [FieldOffset(Offset = "0x10")]
      public string AssetPrefix;
      [Token(Token = "0x4002C53")]
      [FieldOffset(Offset = "0x14")]
      [StringIsResourcePath(typeof (GameObject), "CH/BODY/")]
      public string BodyName;
      [Token(Token = "0x4002C54")]
      [FieldOffset(Offset = "0x18")]
      [StringIsResourcePath(typeof (GameObject), "CH/BODYOPT/")]
      public string BodyAttachmentName;
      [Token(Token = "0x4002C55")]
      [FieldOffset(Offset = "0x1C")]
      [StringIsResourcePath(typeof (Texture2D), "CH/BODYTEX/")]
      public string BodyTextureName;
      [Token(Token = "0x4002C56")]
      [FieldOffset(Offset = "0x20")]
      [StringIsResourcePath(typeof (GameObject), "CH/HEAD/")]
      public string HeadName;
      [Token(Token = "0x4002C57")]
      [FieldOffset(Offset = "0x24")]
      [StringIsResourcePath(typeof (GameObject), "CH/HAIR/")]
      public string HairName;
      [Token(Token = "0x4002C58")]
      [FieldOffset(Offset = "0x28")]
      [StringIsResourcePath(typeof (GameObject), "CH/HEADOPT/")]
      public string HeadAttachmentName;
      [Token(Token = "0x4002C59")]
      [FieldOffset(Offset = "0x2C")]
      public Color32 HairColor0;
      [Token(Token = "0x4002C5A")]
      [FieldOffset(Offset = "0x30")]
      public Color32 HairColor1;
      [Token(Token = "0x4002C5B")]
      [FieldOffset(Offset = "0x34")]
      public bool Movable;
      [Token(Token = "0x4002C5C")]
      [FieldOffset(Offset = "0x35")]
      public bool IsJobDownstand;
      [Token(Token = "0x4002C5D")]
      [FieldOffset(Offset = "0x36")]
      public bool IsJobDodge;
      [Token(Token = "0x4002C5E")]
      [FieldOffset(Offset = "0x37")]
      public bool IsJobDamage;
      [Token(Token = "0x4002C5F")]
      [FieldOffset(Offset = "0x38")]
      public bool IsJobStep;
      [Token(Token = "0x4002C60")]
      [FieldOffset(Offset = "0x39")]
      public bool IsJobFallloop;
      [Token(Token = "0x4002C61")]
      [FieldOffset(Offset = "0x3A")]
      public bool IsJobJumploop;
      [Token(Token = "0x4002C62")]
      [FieldOffset(Offset = "0x3B")]
      public bool IsJobPickup;
      [Token(Token = "0x4002C63")]
      [FieldOffset(Offset = "0x3C")]
      public bool IsJobFreeze;
      [Token(Token = "0x4002C64")]
      [FieldOffset(Offset = "0x3D")]
      public bool IsJobGroggy;
      [Token(Token = "0x4002C65")]
      [FieldOffset(Offset = "0x3E")]
      public bool IsJobRideOnly;
      [Token(Token = "0x4002C66")]
      [FieldOffset(Offset = "0x3F")]
      public bool IsJobCopy;
      [Token(Token = "0x4002C67")]
      [FieldOffset(Offset = "0x40")]
      public bool IsNoTurn;
      [Token(Token = "0x4002C68")]
      [FieldOffset(Offset = "0x41")]
      public bool IsUseCommonAnim;
      [Token(Token = "0x4002C69")]
      [FieldOffset(Offset = "0x42")]
      public bool IsIgnoreExistFile;

      [Token(Token = "0x6003C16")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Job()
      {
      }

      [Token(Token = "0x6003C17")]
      [Address(RVA = "0x10F05F0", Offset = "0x10EF3F0", VA = "0x110F05F0")]
      public Job(string jobID)
      {
      }

      [Token(Token = "0x6003C18")]
      [Address(RVA = "0x10F06D0", Offset = "0x10EF4D0", VA = "0x110F06D0")]
      public Job(CharacterDB.Job _job)
      {
      }

      [Token(Token = "0x6003C19")]
      [Address(RVA = "0x10F0580", Offset = "0x10EF380", VA = "0x110F0580")]
      public void CopyIsJob(CharacterDB.Job _job)
      {
      }
    }

    [Token(Token = "0x2000E7C")]
    [Serializable]
    public class Character
    {
      [Token(Token = "0x4002C6A")]
      [FieldOffset(Offset = "0x8")]
      public int HashID;
      [Token(Token = "0x4002C6B")]
      [FieldOffset(Offset = "0xC")]
      public string CharacterID;
      [Token(Token = "0x4002C6C")]
      [FieldOffset(Offset = "0x10")]
      public List<CharacterDB.Job> Jobs;

      [Token(Token = "0x6003C1A")]
      [Address(RVA = "0x10EAA20", Offset = "0x10E9820", VA = "0x110EAA20")]
      public Character(string characterID)
      {
      }

      [Token(Token = "0x6003C1B")]
      [Address(RVA = "0x10EA980", Offset = "0x10E9780", VA = "0x110EA980")]
      public int IndexOfJob(string jobID) => new int();
    }
  }
}
