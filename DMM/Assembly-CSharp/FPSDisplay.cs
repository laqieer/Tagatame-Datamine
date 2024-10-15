// Decompiled with JetBrains decompiler
// Type: FPSDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20000E3")]
[AddComponentMenu("Common/FPSDisplay")]
public class FPSDisplay : MonoBehaviour
{
  [Token(Token = "0x40003F2")]
  [FieldOffset(Offset = "0xC")]
  private float mDeltaTime;
  [Token(Token = "0x40003F3")]
  [FieldOffset(Offset = "0x10")]
  public Text FPS;
  [Token(Token = "0x40003F4")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private bool IsServerTimeOnly;
  [Token(Token = "0x40003F5")]
  [FieldOffset(Offset = "0x0")]
  private static EnumBitArray<FPSDisplay.DispType> _dispStatus;

  [Token(Token = "0x6000550")]
  [Address(RVA = "0xC6FE60", Offset = "0xC6EC60", VA = "0x10C6FE60")]
  public static bool IsDispOn(FPSDisplay.DispType type) => new bool();

  [Token(Token = "0x6000551")]
  [Address(RVA = "0xC6FC80", Offset = "0xC6EA80", VA = "0x10C6FC80")]
  public static bool DispOn(FPSDisplay.DispType type) => new bool();

  [Token(Token = "0x6000552")]
  [Address(RVA = "0xC6FC10", Offset = "0xC6EA10", VA = "0x10C6FC10")]
  public static bool DispOff(FPSDisplay.DispType type) => new bool();

  [Token(Token = "0x6000553")]
  [Address(RVA = "0xC6FD30", Offset = "0xC6EB30", VA = "0x10C6FD30")]
  public static bool FPSDispOn() => new bool();

  [Token(Token = "0x6000554")]
  [Address(RVA = "0xC6FCF0", Offset = "0xC6EAF0", VA = "0x10C6FCF0")]
  public static bool FPSDispOff() => new bool();

  [Token(Token = "0x6000555")]
  [Address(RVA = "0xC6F690", Offset = "0xC6E490", VA = "0x10C6F690")]
  public static bool ASSETSDispOn() => new bool();

  [Token(Token = "0x6000556")]
  [Address(RVA = "0xC6F650", Offset = "0xC6E450", VA = "0x10C6F650")]
  public static bool ASSETSDispOff() => new bool();

  [Token(Token = "0x6000557")]
  [Address(RVA = "0xC6FF10", Offset = "0xC6ED10", VA = "0x10C6FF10")]
  public static bool MEMORYDispOn() => new bool();

  [Token(Token = "0x6000558")]
  [Address(RVA = "0xC6FED0", Offset = "0xC6ECD0", VA = "0x10C6FED0")]
  public static bool MEMORYDispOff() => new bool();

  [Token(Token = "0x6000559")]
  [Address(RVA = "0xC700F0", Offset = "0xC6EEF0", VA = "0x10C700F0")]
  public static bool TEXTUREDispOn() => new bool();

  [Token(Token = "0x600055A")]
  [Address(RVA = "0xC700B0", Offset = "0xC6EEB0", VA = "0x10C700B0")]
  public static bool TEXTUREDispOff() => new bool();

  [Token(Token = "0x600055B")]
  [Address(RVA = "0xC6FB50", Offset = "0xC6E950", VA = "0x10C6FB50")]
  public static bool BATTLEVERSIONDispOn() => new bool();

  [Token(Token = "0x600055C")]
  [Address(RVA = "0xC6FB10", Offset = "0xC6E910", VA = "0x10C6FB10")]
  public static bool BATTLEVERSIONDispOff() => new bool();

  [Token(Token = "0x600055D")]
  [Address(RVA = "0xC6FBD0", Offset = "0xC6E9D0", VA = "0x10C6FBD0")]
  public static bool CRITICALSECTIONDispOn() => new bool();

  [Token(Token = "0x600055E")]
  [Address(RVA = "0xC6FB90", Offset = "0xC6E990", VA = "0x10C6FB90")]
  public static bool CRITICALSECTIONDispOff() => new bool();

  [Token(Token = "0x600055F")]
  [Address(RVA = "0xC6FF90", Offset = "0xC6ED90", VA = "0x10C6FF90")]
  public static bool SCENETRANSITIONDispOn() => new bool();

  [Token(Token = "0x6000560")]
  [Address(RVA = "0xC6FF50", Offset = "0xC6ED50", VA = "0x10C6FF50")]
  public static bool SCENETRANSITIONDispOff() => new bool();

  [Token(Token = "0x6000561")]
  [Address(RVA = "0xC70010", Offset = "0xC6EE10", VA = "0x10C70010")]
  public static bool SERVERTIMEDispOn() => new bool();

  [Token(Token = "0x6000562")]
  [Address(RVA = "0xC6FFD0", Offset = "0xC6EDD0", VA = "0x10C6FFD0")]
  public static bool SERVERTIMEDispOff() => new bool();

  [Token(Token = "0x6000563")]
  [Address(RVA = "0xC6FD70", Offset = "0xC6EB70", VA = "0x10C6FD70")]
  private void InitDisp()
  {
  }

  [Token(Token = "0x6000564")]
  [Address(RVA = "0xC6F6D0", Offset = "0xC6E4D0", VA = "0x10C6F6D0")]
  public static void AllDispOff()
  {
  }

  [Token(Token = "0x6000565")]
  [Address(RVA = "0xC6F8F0", Offset = "0xC6E6F0", VA = "0x10C6F8F0")]
  public static void AllDispOn()
  {
  }

  [Token(Token = "0x6000566")]
  [Address(RVA = "0xC70050", Offset = "0xC6EE50", VA = "0x10C70050")]
  private void Start()
  {
  }

  [Token(Token = "0x6000567")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000568")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void DisplayDefault()
  {
  }

  [Token(Token = "0x6000569")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void DisplayServerTimeOnly()
  {
  }

  [Token(Token = "0x600056A")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public FPSDisplay()
  {
  }

  [Token(Token = "0x600056B")]
  [Address(RVA = "0xC70130", Offset = "0xC6EF30", VA = "0x10C70130")]
  static FPSDisplay()
  {
  }

  [Token(Token = "0x20000E4")]
  [Flags]
  public enum DispType : byte
  {
    [Token(Token = "0x40003F7")] FPS = 0,
    [Token(Token = "0x40003F8")] ASSETS = 1,
    [Token(Token = "0x40003F9")] MEMORY = 2,
    [Token(Token = "0x40003FA")] TEXTURE = MEMORY | ASSETS, // 0x03
    [Token(Token = "0x40003FB")] BATTLE_VERSION = 4,
    [Token(Token = "0x40003FC")] CRITICAL_SECTION = BATTLE_VERSION | ASSETS, // 0x05
    [Token(Token = "0x40003FD")] SCENE_TRANSITION = BATTLE_VERSION | MEMORY, // 0x06
    [Token(Token = "0x40003FE")] SERVER_TIME = SCENE_TRANSITION | ASSETS, // 0x07
    [Token(Token = "0x40003FF")] MAX = 8,
  }
}
