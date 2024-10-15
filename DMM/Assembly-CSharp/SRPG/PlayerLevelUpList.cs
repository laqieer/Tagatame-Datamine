// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerLevelUpList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027F8")]
  [AddComponentMenu("UI/PlayerLevelUpList")]
  public class PlayerLevelUpList : MonoBehaviour
  {
    [Token(Token = "0x400BE3C")]
    [FieldOffset(Offset = "0xC")]
    [Description("プレイヤーレベルの行")]
    public GameObject Level;
    [Token(Token = "0x400BE3D")]
    [FieldOffset(Offset = "0x10")]
    [Description("現在の出撃ポイントの行")]
    public GameObject StaminaCurrent;
    [Token(Token = "0x400BE3E")]
    [FieldOffset(Offset = "0x14")]
    [Description("最大出撃ポイントの行")]
    public GameObject StaminaMax;
    [Token(Token = "0x400BE3F")]
    [FieldOffset(Offset = "0x18")]
    [Description("最大フレンド枠の行")]
    public GameObject FriendSlotMax;
    [Token(Token = "0x400BE40")]
    [FieldOffset(Offset = "0x1C")]
    [Description("アンロック情報")]
    public GameObject[] UnlockInfo;

    [Token(Token = "0x600B478")]
    [Address(RVA = "0x7B0160", Offset = "0x7AEF60", VA = "0x107B0160")]
    private void Start()
    {
    }

    [Token(Token = "0x600B479")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PlayerLevelUpList()
    {
    }
  }
}
