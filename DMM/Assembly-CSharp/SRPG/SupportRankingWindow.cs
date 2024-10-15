// Decompiled with JetBrains decompiler
// Type: SRPG.SupportRankingWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B11")]
  [FlowNode.Pin(100, "Select User", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/SupportRankingWindow")]
  public class SupportRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D22C")]
    private const int OUTPUT_SELECT_USER = 100;
    [Token(Token = "0x400D22D")]
    [FieldOffset(Offset = "0x0")]
    private static SupportRankingWindow mInstance;
    [Token(Token = "0x400D22E")]
    public const int MAX_SCORE = 999999999;
    [Token(Token = "0x400D22F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mUserParent;
    [Token(Token = "0x400D230")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mUnitParent;
    [Token(Token = "0x400D231")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mUserTemplate;
    [Token(Token = "0x400D232")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mPlayerInfo;
    [Token(Token = "0x400D233")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mUnitTemplete;
    [Token(Token = "0x400D234")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mTabUser;
    [Token(Token = "0x400D235")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mTabUnit;
    [Token(Token = "0x400D236")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mTitleText;
    [Token(Token = "0x400D237")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mCurrentTab;
    [Token(Token = "0x400D23B")]
    [FieldOffset(Offset = "0x3C")]
    private SupportRankingWindow.SupportRankingType mSelectType;

    [Token(Token = "0x17001A30")]
    public static SupportRankingWindow Instance
    {
      [Token(Token = "0x600C51B"), Address(RVA = "0x8DCA30", Offset = "0x8DB830", VA = "0x108DCA30")] get
      {
        return (SupportRankingWindow) null;
      }
    }

    [Token(Token = "0x17001A31")]
    public SupportUserRanking mSupportMyInfo
    {
      [Token(Token = "0x600C51C"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (SupportUserRanking) null;
      }
      [Token(Token = "0x600C51D"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
      {
      }
    }

    [Token(Token = "0x17001A32")]
    public List<SupportUserRanking> mSupportUser
    {
      [Token(Token = "0x600C51E"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (List<SupportUserRanking>) null;
      }
      [Token(Token = "0x600C51F"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] private set
      {
      }
    }

    [Token(Token = "0x17001A33")]
    public List<SupportUnitRanking> mSupportUnit
    {
      [Token(Token = "0x600C520"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (List<SupportUnitRanking>) null;
      }
      [Token(Token = "0x600C521"), Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")] private set
      {
      }
    }

    [Token(Token = "0x600C522")]
    [Address(RVA = "0x8DB870", Offset = "0x8DA670", VA = "0x108DB870")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C523")]
    [Address(RVA = "0x8DBED0", Offset = "0x8DACD0", VA = "0x108DBED0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C524")]
    [Address(RVA = "0x8DBAA0", Offset = "0x8DA8A0", VA = "0x108DBAA0")]
    public void Init()
    {
    }

    [Token(Token = "0x600C525")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C526")]
    [Address(RVA = "0x8DC0E0", Offset = "0x8DAEE0", VA = "0x108DC0E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C527")]
    [Address(RVA = "0x8DBDD0", Offset = "0x8DABD0", VA = "0x108DBDD0")]
    public void OnClickTab(GameObject go)
    {
    }

    [Token(Token = "0x600C528")]
    [Address(RVA = "0x8DC020", Offset = "0x8DAE20", VA = "0x108DC020")]
    public void OnUserClick(GameObject go)
    {
    }

    [Token(Token = "0x600C529")]
    [Address(RVA = "0x8DBF10", Offset = "0x8DAD10", VA = "0x108DBF10")]
    public void OnGuildClick(GameObject go)
    {
    }

    [Token(Token = "0x600C52A")]
    [Address(RVA = "0x8DC440", Offset = "0x8DB240", VA = "0x108DC440")]
    public void SetupSupportUserRanking(JSON_SupportRankingUser json)
    {
    }

    [Token(Token = "0x600C52B")]
    [Address(RVA = "0x8DC150", Offset = "0x8DAF50", VA = "0x108DC150")]
    public void SetupSupportUnitRanking(JSON_SupportRankingUnit json)
    {
    }

    [Token(Token = "0x600C52C")]
    [Address(RVA = "0x8DCA10", Offset = "0x8DB810", VA = "0x108DCA10")]
    public SupportRankingWindow()
    {
    }

    [Token(Token = "0x2002B12")]
    private enum SupportRankingType
    {
      [Token(Token = "0x400D23D")] User,
      [Token(Token = "0x400D23E")] Unit,
    }
  }
}
