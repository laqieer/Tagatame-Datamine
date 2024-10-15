// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalListItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002287")]
  public class CrystalListItemParam : ContentSource.Param
  {
    [Token(Token = "0x4009941")]
    private const string UNIT_ICON_SPRITE_PATH = "ItemIcon/small";
    [Token(Token = "0x4009951")]
    [FieldOffset(Offset = "0x48")]
    private CrystalScrollList mScrollList;
    [Token(Token = "0x4009952")]
    [FieldOffset(Offset = "0x4C")]
    private CrystalData mData;
    [Token(Token = "0x4009953")]
    [FieldOffset(Offset = "0x50")]
    private CrystalParam mParam;
    [Token(Token = "0x4009954")]
    [FieldOffset(Offset = "0x54")]
    private UnitData mUnitData;
    [Token(Token = "0x4009955")]
    [FieldOffset(Offset = "0x58")]
    private CrystalListItemNode mNode;
    [Token(Token = "0x4009956")]
    [FieldOffset(Offset = "0x5C")]
    private bool mRemoveEquip;

    [Token(Token = "0x170014B7")]
    public int UniqueId
    {
      [Token(Token = "0x600938E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600938F"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x170014B8")]
    public bool IsUsed
    {
      [Token(Token = "0x6009390"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009391"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
      {
      }
    }

    [Token(Token = "0x170014B9")]
    public Sprite EquipUnitSprite
    {
      [Token(Token = "0x6009392"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x6009393"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x170014BA")]
    public bool IsEquip
    {
      [Token(Token = "0x6009394"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009395"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
      {
      }
    }

    [Token(Token = "0x170014BB")]
    public Sprite ArenaEquipUnitSprite
    {
      [Token(Token = "0x6009396"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x6009397"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x170014BC")]
    public bool IsArenaEquip
    {
      [Token(Token = "0x6009398"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009399"), Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")] private set
      {
      }
    }

    [Token(Token = "0x170014BD")]
    public List<Sprite> SupportEquipUnitSpriteList
    {
      [Token(Token = "0x600939A"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<Sprite>) null;
      }
      [Token(Token = "0x600939B"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x170014BE")]
    public bool IsSupportEquip
    {
      [Token(Token = "0x600939C"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600939D"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] private set
      {
      }
    }

    [Token(Token = "0x170014BF")]
    public Sprite GvGEquipUnitSprite
    {
      [Token(Token = "0x600939E"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600939F"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
      {
      }
    }

    [Token(Token = "0x170014C0")]
    public bool IsGvGEquip
    {
      [Token(Token = "0x60093A0"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60093A1"), Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")] private set
      {
      }
    }

    [Token(Token = "0x170014C1")]
    public Sprite LeaguematchEquipUnitSprite
    {
      [Token(Token = "0x60093A2"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x60093A3"), Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")] private set
      {
      }
    }

    [Token(Token = "0x170014C2")]
    public bool IsLeaguematchEquip
    {
      [Token(Token = "0x60093A4"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
      [Token(Token = "0x60093A5"), Address(RVA = "0x428390", Offset = "0x427190", VA = "0x10428390")] private set
      {
      }
    }

    [Token(Token = "0x170014C3")]
    public bool IsEquipMainSlot
    {
      [Token(Token = "0x60093A6"), Address(RVA = "0x56B2D0", Offset = "0x56A0D0", VA = "0x1056B2D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60093A7"), Address(RVA = "0x56B2F0", Offset = "0x56A0F0", VA = "0x1056B2F0")] private set
      {
      }
    }

    [Token(Token = "0x170014C4")]
    public CrystalData.ESlotIndex SelectSlotIndex
    {
      [Token(Token = "0x60093A8"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new CrystalData.ESlotIndex();
      }
      [Token(Token = "0x60093A9"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
      {
      }
    }

    [Token(Token = "0x170014C5")]
    public int HaveAmount
    {
      [Token(Token = "0x60093AA"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60093AB"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
      {
      }
    }

    [Token(Token = "0x60093AC")]
    [Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")]
    public CrystalData GetData() => (CrystalData) null;

    [Token(Token = "0x60093AD")]
    [Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")]
    public CrystalParam GetParam() => (CrystalParam) null;

    [Token(Token = "0x60093AE")]
    [Address(RVA = "0x56A5A0", Offset = "0x5693A0", VA = "0x1056A5A0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x60093AF")]
    [Address(RVA = "0x56A580", Offset = "0x569380", VA = "0x1056A580", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x60093B0")]
    [Address(RVA = "0x56A770", Offset = "0x569570", VA = "0x1056A770")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60093B1")]
    [Address(RVA = "0x56A800", Offset = "0x569600", VA = "0x1056A800")]
    public void SetData(
      CrystalScrollList _scroll_list,
      CrystalData _data,
      UnityAction _callback,
      UnitData _unit_data,
      int _unique_id,
      CrystalData.ESlotIndex _select_index,
      bool _is_have_count = false)
    {
    }

    [Token(Token = "0x60093B2")]
    [Address(RVA = "0x56B030", Offset = "0x569E30", VA = "0x1056B030")]
    public void SetParam(
      CrystalScrollList _scroll_list,
      CrystalParam _param,
      UnityAction _callback,
      UnitData _unit_data,
      int _unique_id,
      bool _is_have_count = false)
    {
    }

    [Token(Token = "0x60093B3")]
    [Address(RVA = "0x56B0B0", Offset = "0x569EB0", VA = "0x1056B0B0")]
    public void SetRemoveEquip(CrystalScrollList _scroll_list)
    {
    }

    [Token(Token = "0x60093B4")]
    [Address(RVA = "0x56A6E0", Offset = "0x5694E0", VA = "0x1056A6E0")]
    public void ReDraw()
    {
    }

    [Token(Token = "0x60093B5")]
    [Address(RVA = "0x56B0D0", Offset = "0x569ED0", VA = "0x1056B0D0")]
    private void SetUsed()
    {
    }

    [Token(Token = "0x60093B6")]
    [Address(RVA = "0x56A890", Offset = "0x569690", VA = "0x1056A890")]
    private void SetEquipIcon()
    {
    }

    [Token(Token = "0x60093B7")]
    [Address(RVA = "0x56A3A0", Offset = "0x5691A0", VA = "0x1056A3A0")]
    private void CalcHaveAmount()
    {
    }

    [Token(Token = "0x60093B8")]
    [Address(RVA = "0x56B260", Offset = "0x56A060", VA = "0x1056B260")]
    public void UpdateData(CrystalData _data)
    {
    }

    [Token(Token = "0x60093B9")]
    [Address(RVA = "0x56A550", Offset = "0x569350", VA = "0x1056A550")]
    public bool IsEquipAny() => new bool();

    [Token(Token = "0x60093BA")]
    [Address(RVA = "0x56B2A0", Offset = "0x56A0A0", VA = "0x1056B2A0")]
    public CrystalListItemParam()
    {
    }
  }
}
