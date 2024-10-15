// Decompiled with JetBrains decompiler
// Type: SRPG.TowerLevelLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B40")]
  [AddComponentMenu("UI/TowerLevelLock")]
  [RequireComponent(typeof (Selectable))]
  public class TowerLevelLock : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
  {
    [Token(Token = "0x400D351")]
    [FieldOffset(Offset = "0xC")]
    public Text ConditionText;
    [Token(Token = "0x400D352")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ShowLocked;
    [Token(Token = "0x400D353")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ShowUnlocked;
    [Token(Token = "0x400D354")]
    [FieldOffset(Offset = "0x18")]
    public bool ToggleInteractable;
    [Token(Token = "0x400D355")]
    [FieldOffset(Offset = "0x1C")]
    private int mUnlockLevel;
    [Token(Token = "0x400D356")]
    [FieldOffset(Offset = "0x20")]
    private TowerParam Param;

    [Token(Token = "0x600C5EE")]
    [Address(RVA = "0x8E79C0", Offset = "0x8E67C0", VA = "0x108E79C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C5EF")]
    [Address(RVA = "0x8E74B0", Offset = "0x8E62B0", VA = "0x108E74B0")]
    public bool GetIsUnlock() => new bool();

    [Token(Token = "0x600C5F0")]
    [Address(RVA = "0x8E7A30", Offset = "0x8E6830", VA = "0x108E7A30")]
    private void UpdateLockState()
    {
    }

    [Token(Token = "0x600C5F1")]
    [Address(RVA = "0x8E7790", Offset = "0x8E6590", VA = "0x108E7790")]
    public string ShowLockMessage(int playerLv, int reqLv) => (string) null;

    [Token(Token = "0x600C5F2")]
    [Address(RVA = "0x8E7810", Offset = "0x8E6610", VA = "0x108E7810")]
    public string ShowProgLockMessage() => (string) null;

    [Token(Token = "0x600C5F3")]
    [Address(RVA = "0x8E7570", Offset = "0x8E6370", VA = "0x108E7570", Slot = "4")]
    public void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C5F4")]
    [Address(RVA = "0x8E7520", Offset = "0x8E6320", VA = "0x108E7520")]
    public TowerParam GetTowerParam(string tower_id) => (TowerParam) null;

    [Token(Token = "0x600C5F5")]
    [Address(RVA = "0x8E74D0", Offset = "0x8E62D0", VA = "0x108E74D0")]
    public TowerFloorParam GetTowerFloorParam(string iname) => (TowerFloorParam) null;

    [Token(Token = "0x600C5F6")]
    [Address(RVA = "0x37ACE0", Offset = "0x379AE0", VA = "0x1037ACE0")]
    private bool IsIgnorePlayerLevel() => new bool();

    [Token(Token = "0x600C5F7")]
    [Address(RVA = "0x8E7C50", Offset = "0x8E6A50", VA = "0x108E7C50")]
    public TowerLevelLock()
    {
    }
  }
}
