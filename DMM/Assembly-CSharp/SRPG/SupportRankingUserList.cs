// Decompiled with JetBrains decompiler
// Type: SRPG.SupportRankingUserList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B10")]
  [AddComponentMenu("UI/SupportRankingUserList")]
  public class SupportRankingUserList : MonoBehaviour
  {
    [Token(Token = "0x400D221")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRankImage;
    [Token(Token = "0x400D222")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400D223")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mName;
    [Token(Token = "0x400D224")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mLevel;
    [Token(Token = "0x400D225")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mGuildName;
    [Token(Token = "0x400D226")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mScore;
    [Token(Token = "0x400D227")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mGuildNone;
    [Token(Token = "0x400D228")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mPlayerLock;
    [Token(Token = "0x400D229")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mOverGold;
    [Token(Token = "0x400D22A")]
    [FieldOffset(Offset = "0x30")]
    public int PLAYER_LOCK;
    [Token(Token = "0x400D22B")]
    private const int DEFAULT_RANKING_NOTEXT = 3;

    [Token(Token = "0x600C518")]
    [Address(RVA = "0x8DB2D0", Offset = "0x8DA0D0", VA = "0x108DB2D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C519")]
    [Address(RVA = "0x8DB340", Offset = "0x8DA140", VA = "0x108DB340")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C51A")]
    [Address(RVA = "0x8DB850", Offset = "0x8DA650", VA = "0x108DB850")]
    public SupportRankingUserList()
    {
    }
  }
}
