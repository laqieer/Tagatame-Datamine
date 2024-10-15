// Decompiled with JetBrains decompiler
// Type: SRPG.SystemInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F24")]
  [AddComponentMenu("Scripts/SRPG/System/SystemInstance")]
  public class SystemInstance : MonoSingleton<SystemInstance>
  {
    [Token(Token = "0x400830E")]
    [FieldOffset(Offset = "0x0")]
    private static System.Type[] SYSTEM_INSTANCE;

    [Token(Token = "0x6007F6D")]
    [Address(RVA = "0x411BD0", Offset = "0x4109D0", VA = "0x10411BD0", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x6007F6E")]
    [Address(RVA = "0x411EF0", Offset = "0x410CF0", VA = "0x10411EF0")]
    public SystemInstance()
    {
    }

    [Token(Token = "0x6007F6F")]
    [Address(RVA = "0x411D60", Offset = "0x410B60", VA = "0x10411D60")]
    static SystemInstance()
    {
    }
  }
}
