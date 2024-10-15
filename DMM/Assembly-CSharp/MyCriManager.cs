// Decompiled with JetBrains decompiler
// Type: MyCriManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000259")]
public class MyCriManager
{
  [Token(Token = "0x40009F8")]
  [FieldOffset(Offset = "0x0")]
  private static bool sInit;
  [Token(Token = "0x40009F9")]
  [FieldOffset(Offset = "0x4")]
  public static readonly string AcfFileNameTutorialEmb;
  [Token(Token = "0x40009FA")]
  [FieldOffset(Offset = "0x8")]
  public static readonly string DatFileNameTutorialEmb;
  [Token(Token = "0x40009FB")]
  [FieldOffset(Offset = "0xC")]
  public static readonly string AcfFileNameEmb;
  [Token(Token = "0x40009FC")]
  [FieldOffset(Offset = "0x10")]
  public static readonly string DatFileNameEmb;
  [Token(Token = "0x40009FD")]
  [FieldOffset(Offset = "0x14")]
  public static readonly string AcfFileNameAB;
  [Token(Token = "0x40009FE")]
  [FieldOffset(Offset = "0x18")]
  public static readonly string DatFileNameAB;
  [Token(Token = "0x4000A00")]
  [FieldOffset(Offset = "0x20")]
  private static GameObject sCriWareInitializer;

  [Token(Token = "0x1700017A")]
  public static string AcfFileName
  {
    [Token(Token = "0x6000C8E"), Address(RVA = "0x1082BF0", Offset = "0x10819F0", VA = "0x11082BF0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000C8F"), Address(RVA = "0x1082C70", Offset = "0x1081A70", VA = "0x11082C70")] private set
    {
    }
  }

  [Token(Token = "0x1700017B")]
  public static bool UsingEmb
  {
    [Token(Token = "0x6000C90"), Address(RVA = "0x1082C30", Offset = "0x1081A30", VA = "0x11082C30")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000C91"), Address(RVA = "0x1082CD0", Offset = "0x1081AD0", VA = "0x11082CD0")] private set
    {
    }
  }

  [Token(Token = "0x6000C92")]
  [Address(RVA = "0x1082510", Offset = "0x1081310", VA = "0x11082510")]
  public static void Setup(bool useEmb = false)
  {
  }

  [Token(Token = "0x6000C93")]
  [Address(RVA = "0x1081EF0", Offset = "0x1080CF0", VA = "0x11081EF0")]
  public static string GetLoadFileName(string acb, bool isUnManaged = false) => (string) null;

  [Token(Token = "0x6000C94")]
  [Address(RVA = "0x10820C0", Offset = "0x1080EC0", VA = "0x110820C0")]
  public static bool IsInitialized() => new bool();

  [Token(Token = "0x6000C95")]
  [Address(RVA = "0x1082100", Offset = "0x1080F00", VA = "0x11082100")]
  public static void ReSetup(bool useEmb)
  {
  }

  [Token(Token = "0x6000C96")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public MyCriManager()
  {
  }

  [Token(Token = "0x6000C97")]
  [Address(RVA = "0x1082A70", Offset = "0x1081870", VA = "0x11082A70")]
  static MyCriManager()
  {
  }
}
