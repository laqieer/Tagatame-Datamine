// Decompiled with JetBrains decompiler
// Type: MyGrowthPush
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000250")]
[AddComponentMenu("/MyGrowthPush")]
public class MyGrowthPush : MonoSingleton<MyGrowthPush>
{
  [Token(Token = "0x40009D6")]
  [FieldOffset(Offset = "0xC")]
  private string applicationId;
  [Token(Token = "0x40009D7")]
  [FieldOffset(Offset = "0x10")]
  private string credentialId;
  [Token(Token = "0x40009D8")]
  [FieldOffset(Offset = "0x14")]
  private string senderId;

  [Token(Token = "0x6000C4F")]
  [Address(RVA = "0x1084B10", Offset = "0x1083910", VA = "0x11084B10")]
  public GrowthPush.Environment getEnvironment() => new GrowthPush.Environment();

  [Token(Token = "0x6000C50")]
  [Address(RVA = "0x1084770", Offset = "0x1083570", VA = "0x11084770", Slot = "4")]
  protected override void Initialize()
  {
  }

  [Token(Token = "0x6000C51")]
  [Address(RVA = "0x10847C0", Offset = "0x10835C0", VA = "0x110847C0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000C52")]
  [Address(RVA = "0x1084B60", Offset = "0x1083960", VA = "0x11084B60")]
  public void registCustomerId(string cuid)
  {
  }

  [Token(Token = "0x6000C53")]
  [Address(RVA = "0x1084810", Offset = "0x1083610", VA = "0x11084810")]
  public void Setup()
  {
  }

  [Token(Token = "0x6000C54")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void RequestAuth()
  {
  }

  [Token(Token = "0x6000C55")]
  [Address(RVA = "0x1084A70", Offset = "0x1083870", VA = "0x11084A70")]
  public MyGrowthPush()
  {
  }
}
