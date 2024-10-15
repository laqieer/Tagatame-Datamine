// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftPartyUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002734")]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftPartyUnit")]
  public class VersusDraftPartyUnit : MonoBehaviour
  {
    [Token(Token = "0x400B8FB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mSelected;
    [Token(Token = "0x400B8FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject lockObject;
    [Token(Token = "0x400B8FD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400B8FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitIconEx unitIconEx;
    [Token(Token = "0x400B8FF")]
    [FieldOffset(Offset = "0x0")]
    private static VersusDraftPartyEdit mVersusDraftPartyEdit;
    [Token(Token = "0x400B900")]
    [FieldOffset(Offset = "0x1C")]
    private UnitData mUnitData;
    [Token(Token = "0x400B901")]
    [FieldOffset(Offset = "0x20")]
    private VersusDraftPartySlot mTargetSlot;
    [Token(Token = "0x400B902")]
    [FieldOffset(Offset = "0x24")]
    private bool isLock;

    [Token(Token = "0x17001849")]
    public static VersusDraftPartyEdit VersusDraftPartyEdit
    {
      [Token(Token = "0x600AFD8"), Address(RVA = "0x741E70", Offset = "0x740C70", VA = "0x10741E70")] get
      {
        return (VersusDraftPartyEdit) null;
      }
      [Token(Token = "0x600AFD9"), Address(RVA = "0x741EA0", Offset = "0x740CA0", VA = "0x10741EA0")] set
      {
      }
    }

    [Token(Token = "0x1700184A")]
    public UnitData UnitData
    {
      [Token(Token = "0x600AFDA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x1700184B")]
    public bool IsSetSlot
    {
      [Token(Token = "0x600AFDB"), Address(RVA = "0x741E20", Offset = "0x740C20", VA = "0x10741E20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700184C")]
    public bool IsLock
    {
      [Token(Token = "0x600AFDC"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600AFDD")]
    [Address(RVA = "0x741CC0", Offset = "0x740AC0", VA = "0x10741CC0")]
    public void SetUp(UnitData unit, bool _isLock)
    {
    }

    [Token(Token = "0x600AFDE")]
    [Address(RVA = "0x741940", Offset = "0x740740", VA = "0x10741940")]
    public void OnClick(Button button)
    {
    }

    [Token(Token = "0x600AFDF")]
    [Address(RVA = "0x741C70", Offset = "0x740A70", VA = "0x10741C70")]
    public void Select(VersusDraftPartySlot slot)
    {
    }

    [Token(Token = "0x600AFE0")]
    [Address(RVA = "0x741BE0", Offset = "0x7409E0", VA = "0x10741BE0")]
    public void Reset()
    {
    }

    [Token(Token = "0x600AFE1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusDraftPartyUnit()
    {
    }
  }
}
