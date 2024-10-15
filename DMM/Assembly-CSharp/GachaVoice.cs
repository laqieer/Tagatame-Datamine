// Decompiled with JetBrains decompiler
// Type: GachaVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000E6")]
[AddComponentMenu("Common/GachaVoice")]
public class GachaVoice : MonoBehaviour
{
  [Token(Token = "0x4000402")]
  [FieldOffset(Offset = "0xC")]
  public string DirectCharName;
  [Token(Token = "0x4000403")]
  [FieldOffset(Offset = "0x10")]
  public int Excites;
  [Token(Token = "0x4000404")]
  [FieldOffset(Offset = "0x14")]
  public string Play1CueName;
  [Token(Token = "0x4000405")]
  [FieldOffset(Offset = "0x18")]
  public string Play2CueName;
  [Token(Token = "0x4000406")]
  [FieldOffset(Offset = "0x1C")]
  public string[] Play3Cuename;
  [Token(Token = "0x4000407")]
  [FieldOffset(Offset = "0x20")]
  private int excites;
  [Token(Token = "0x4000408")]
  [FieldOffset(Offset = "0x24")]
  private string mCharName;
  [Token(Token = "0x4000409")]
  [FieldOffset(Offset = "0x28")]
  private string mCueName;
  [Token(Token = "0x400040A")]
  [FieldOffset(Offset = "0x2C")]
  private MySound.Voice mVoice;

  [Token(Token = "0x6000571")]
  [Address(RVA = "0xC70FB0", Offset = "0xC6FDB0", VA = "0x10C70FB0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000572")]
  [Address(RVA = "0xC710C0", Offset = "0xC6FEC0", VA = "0x10C710C0")]
  public void Play1()
  {
  }

  [Token(Token = "0x6000573")]
  [Address(RVA = "0xC71130", Offset = "0xC6FF30", VA = "0x10C71130")]
  public void Play2()
  {
  }

  [Token(Token = "0x6000574")]
  [Address(RVA = "0xC711A0", Offset = "0xC6FFA0", VA = "0x10C711A0")]
  public void Play3()
  {
  }

  [Token(Token = "0x6000575")]
  [Address(RVA = "0xC71240", Offset = "0xC70040", VA = "0x10C71240")]
  private void Play()
  {
  }

  [Token(Token = "0x6000576")]
  [Address(RVA = "0xC712C0", Offset = "0xC700C0", VA = "0x10C712C0")]
  public void Stop()
  {
  }

  [Token(Token = "0x6000577")]
  [Address(RVA = "0xC71070", Offset = "0xC6FE70", VA = "0x10C71070")]
  public void Discard()
  {
  }

  [Token(Token = "0x6000578")]
  [Address(RVA = "0xC71270", Offset = "0xC70070", VA = "0x10C71270")]
  public bool SetupCueName(string cuename) => new bool();

  [Token(Token = "0x6000579")]
  [Address(RVA = "0xC712F0", Offset = "0xC700F0", VA = "0x10C712F0")]
  public GachaVoice()
  {
  }
}
