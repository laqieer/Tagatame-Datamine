// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftPartySlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002733")]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftPartySlot")]
  public class VersusDraftPartySlot : MonoBehaviour
  {
    [Token(Token = "0x400B8F1")]
    [FieldOffset(Offset = "0x0")]
    private static VersusDraftPartyEdit mVersusDraftPartyEdit;
    [Token(Token = "0x400B8F2")]
    [FieldOffset(Offset = "0x4")]
    private static VersusDraftPartySlot mCurrentSelected;
    [Token(Token = "0x400B8F3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mLeaderIcon;
    [Token(Token = "0x400B8F4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mLocked;
    [Token(Token = "0x400B8F5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mSelect;
    [Token(Token = "0x400B8F6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Selectable mSelectable;
    [Token(Token = "0x400B8F7")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsLeader;
    [Token(Token = "0x400B8F8")]
    [FieldOffset(Offset = "0x1D")]
    private bool mIsLock;
    [Token(Token = "0x400B8F9")]
    [FieldOffset(Offset = "0x20")]
    private DataSource mDataSource;
    [Token(Token = "0x400B8FA")]
    [FieldOffset(Offset = "0x24")]
    private VersusDraftPartyUnit mPartyUnit;

    [Token(Token = "0x17001844")]
    public static VersusDraftPartyEdit VersusDraftPartyEdit
    {
      [Token(Token = "0x600AFCD"), Address(RVA = "0x7418D0", Offset = "0x7406D0", VA = "0x107418D0")] get
      {
        return (VersusDraftPartyEdit) null;
      }
      [Token(Token = "0x600AFCE"), Address(RVA = "0x741900", Offset = "0x740700", VA = "0x10741900")] set
      {
      }
    }

    [Token(Token = "0x17001845")]
    public static VersusDraftPartySlot CurrentSelected
    {
      [Token(Token = "0x600AFCF"), Address(RVA = "0x7418A0", Offset = "0x7406A0", VA = "0x107418A0")] get
      {
        return (VersusDraftPartySlot) null;
      }
    }

    [Token(Token = "0x17001846")]
    public bool IsLeader
    {
      [Token(Token = "0x600AFD0"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001847")]
    public bool IsLock
    {
      [Token(Token = "0x600AFD1"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600AFD2")]
    [Address(RVA = "0x7417F0", Offset = "0x7405F0", VA = "0x107417F0")]
    public void SetUp(bool is_leader, bool is_locked)
    {
    }

    [Token(Token = "0x600AFD3")]
    [Address(RVA = "0x741530", Offset = "0x740330", VA = "0x10741530")]
    public void OnClick(Button button)
    {
    }

    [Token(Token = "0x600AFD4")]
    [Address(RVA = "0x7415B0", Offset = "0x7403B0", VA = "0x107415B0")]
    public void SelectSlot(bool selected)
    {
    }

    [Token(Token = "0x17001848")]
    public VersusDraftPartyUnit PartyUnit
    {
      [Token(Token = "0x600AFD5"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (VersusDraftPartyUnit) null;
      }
    }

    [Token(Token = "0x600AFD6")]
    [Address(RVA = "0x741690", Offset = "0x740490", VA = "0x10741690")]
    public void SetUnit(VersusDraftPartyUnit partyUnit)
    {
    }

    [Token(Token = "0x600AFD7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusDraftPartySlot()
    {
    }
  }
}
