// Decompiled with JetBrains decompiler
// Type: SRPG.LocalNotificationParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BE0")]
  [Serializable]
  public class LocalNotificationParam
  {
    [Token(Token = "0x4006BC9")]
    [FieldOffset(Offset = "0x8")]
    public string msg_stamina;
    [Token(Token = "0x4006BCA")]
    [FieldOffset(Offset = "0xC")]
    public string iOSAct_stamina;
    [Token(Token = "0x4006BCB")]
    [FieldOffset(Offset = "0x10")]
    public int limitSec_stamina;

    [Token(Token = "0x6007307")]
    [Address(RVA = "0x37AD70", Offset = "0x379B70", VA = "0x1037AD70")]
    public LocalNotificationParam()
    {
    }
  }
}
