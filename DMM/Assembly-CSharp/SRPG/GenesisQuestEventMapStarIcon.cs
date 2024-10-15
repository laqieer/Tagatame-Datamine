// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisQuestEventMapStarIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024F5")]
  public class GenesisQuestEventMapStarIcon : ListItemEvents
  {
    [Token(Token = "0x400A8E6")]
    private const int PIN_IN_ON_CLICK = 1;
    [Token(Token = "0x400A8E7")]
    private const int PIN_OUT_OPEN_POPUP = 101;
    [Token(Token = "0x400A8E8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ImageArray[] mTargetIconList;
    [Token(Token = "0x400A8E9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mNeedStar;
    [Token(Token = "0x400A8EA")]
    [FieldOffset(Offset = "0x40")]
    private int mIndex;
    [Token(Token = "0x400A8EB")]
    [FieldOffset(Offset = "0x44")]
    private GenesisQuestEventMapStarIcon.EStartMissionState mState;

    [Token(Token = "0x170016B7")]
    public int Index
    {
      [Token(Token = "0x600A25C"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170016B8")]
    public GenesisQuestEventMapStarIcon.EStartMissionState State
    {
      [Token(Token = "0x600A25D"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new GenesisQuestEventMapStarIcon.EStartMissionState();
      }
    }

    [Token(Token = "0x600A25E")]
    [Address(RVA = "0x644470", Offset = "0x643270", VA = "0x10644470")]
    public void Init(int count, int index, int totalStarNum, GenesisStarRewardParam gsr)
    {
    }

    [Token(Token = "0x600A25F")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public GenesisQuestEventMapStarIcon()
    {
    }

    [Token(Token = "0x20024F6")]
    public enum EStartMissionState
    {
      [Token(Token = "0x400A8ED")] NotReceive,
      [Token(Token = "0x400A8EE")] CanReceive,
      [Token(Token = "0x400A8EF")] Received,
    }
  }
}
