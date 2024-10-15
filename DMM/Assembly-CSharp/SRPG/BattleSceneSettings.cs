// Decompiled with JetBrains decompiler
// Type: SRPG.BattleSceneSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C41")]
  [AddComponentMenu("Battle/BattleSceneSettings")]
  public class BattleSceneSettings : SceneRoot
  {
    [Token(Token = "0x400204B")]
    [FieldOffset(Offset = "0xC")]
    public Transform PlayerStart1;
    [Token(Token = "0x400204C")]
    [FieldOffset(Offset = "0x10")]
    public Transform PlayerStart2;

    [Token(Token = "0x600308E")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public BattleSceneSettings()
    {
    }
  }
}
