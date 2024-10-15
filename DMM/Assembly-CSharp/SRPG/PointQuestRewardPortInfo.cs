// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRewardPortInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200284E")]
  public class PointQuestRewardPortInfo : MonoBehaviour
  {
    [Token(Token = "0x400C060")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mGuildNameText;
    [Token(Token = "0x400C061")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mGuildSymbol;
    [Token(Token = "0x400C062")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private BitmapText mGuildLevelText;
    [Token(Token = "0x400C063")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BitmapText mGuildPointText;
    [Token(Token = "0x400C064")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string DefaultText;
    [Token(Token = "0x400C065")]
    [FieldOffset(Offset = "0x20")]
    public PointQuestGuildInfoData guildInfoData;
    [Token(Token = "0x400C066")]
    [FieldOffset(Offset = "0x24")]
    public int guildMinePoint;
    [Token(Token = "0x400C067")]
    private const string GuildEmblemeImagePath = "GuildEmblemImage/GuildEmblemes";

    [Token(Token = "0x600B5EC")]
    [Address(RVA = "0x7C1AD0", Offset = "0x7C08D0", VA = "0x107C1AD0")]
    public void Setup()
    {
    }

    [Token(Token = "0x600B5ED")]
    [Address(RVA = "0x7C1960", Offset = "0x7C0760", VA = "0x107C1960")]
    private void GetEmblem(GameObject obj, string name)
    {
    }

    [Token(Token = "0x600B5EE")]
    [Address(RVA = "0x7C1E70", Offset = "0x7C0C70", VA = "0x107C1E70")]
    public PointQuestRewardPortInfo()
    {
    }
  }
}
