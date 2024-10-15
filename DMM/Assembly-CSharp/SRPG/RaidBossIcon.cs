// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBossIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028D8")]
  [AddComponentMenu("UI/Raid/RaidBossIcon")]
  public class RaidBossIcon : MonoBehaviour
  {
    [Token(Token = "0x400C419")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_Button mButton;
    [Token(Token = "0x400C41A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mClosed;
    [Token(Token = "0x400C41B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mChallenge;
    [Token(Token = "0x400C41C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mCleared;
    [Token(Token = "0x400C41D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mCursor;
    [Token(Token = "0x400C41E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CustomSound mCursorSound;
    [Token(Token = "0x400C41F")]
    [FieldOffset(Offset = "0x24")]
    private RaidBossInfo mRaidBossInfo;
    [Token(Token = "0x400C420")]
    [FieldOffset(Offset = "0x28")]
    private int mNo;

    [Token(Token = "0x17001939")]
    public bool IsClosed
    {
      [Token(Token = "0x600B8A3"), Address(RVA = "0x37ACB0", Offset = "0x379AB0", VA = "0x1037ACB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700193A")]
    public int No
    {
      [Token(Token = "0x600B8A4"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B8A5")]
    [Address(RVA = "0x7FA2B0", Offset = "0x7F90B0", VA = "0x107FA2B0")]
    public void Setup(RaidBossInfo info, int no)
    {
    }

    [Token(Token = "0x600B8A6")]
    [Address(RVA = "0x7FA020", Offset = "0x7F8E20", VA = "0x107FA020")]
    public void Active()
    {
    }

    [Token(Token = "0x600B8A7")]
    [Address(RVA = "0x7FA200", Offset = "0x7F9000", VA = "0x107FA200")]
    public void SetCursor(bool active, bool sound = true)
    {
    }

    [Token(Token = "0x600B8A8")]
    [Address(RVA = "0x7FA190", Offset = "0x7F8F90", VA = "0x107FA190")]
    public void OnClearedDetail()
    {
    }

    [Token(Token = "0x600B8A9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidBossIcon()
    {
    }
  }
}
