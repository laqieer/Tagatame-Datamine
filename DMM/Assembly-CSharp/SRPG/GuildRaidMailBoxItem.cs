// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidMailBoxItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200257A")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidMailBoxItem")]
  public class GuildRaidMailBoxItem : MonoBehaviour
  {
    [Token(Token = "0x400AD44")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_Button GetReceiveButton;
    [Token(Token = "0x400AD45")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject RewardUnit;
    [Token(Token = "0x400AD46")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject RewardItem;
    [Token(Token = "0x400AD47")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject RewardCard;
    [Token(Token = "0x400AD48")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject RewardArtifact;
    [Token(Token = "0x400AD49")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject RewardAward;
    [Token(Token = "0x400AD4A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject RewardGold;
    [Token(Token = "0x400AD4B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject RewardCoin;

    [Token(Token = "0x600A5F0")]
    [Address(RVA = "0x680210", Offset = "0x67F010", VA = "0x10680210")]
    public void Setup(GuildRaidMailListItem item, SRPG_Button.ButtonClickEvent callback)
    {
    }

    [Token(Token = "0x600A5F1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRaidMailBoxItem()
    {
    }
  }
}
