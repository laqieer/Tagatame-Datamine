// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityRankUpPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F30")]
  [AddComponentMenu("UI/AbilityRankUpPanel")]
  public class AbilityRankUpPanel : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4008338")]
    [FieldOffset(Offset = "0xC")]
    public Text RemainingCount;
    [Token(Token = "0x4008339")]
    [FieldOffset(Offset = "0x10")]
    public GameObject RecoveryTimeParent;
    [Token(Token = "0x400833A")]
    [FieldOffset(Offset = "0x14")]
    public Text RecoveryTimeText;
    [Token(Token = "0x400833B")]
    [FieldOffset(Offset = "0x18")]
    public SRPG_Button ResetButton;
    [Token(Token = "0x400833C")]
    [FieldOffset(Offset = "0x1C")]
    public AbilityRankUpPanel.ResetAbilityRankUpCountEvent OnAbilityRankUpCountReset;
    [Token(Token = "0x400833D")]
    [FieldOffset(Offset = "0x20")]
    public string AB_RANKUP_ADD_WINDOW_PATH;

    [Token(Token = "0x6007FAD")]
    [Address(RVA = "0x4034B0", Offset = "0x4022B0", VA = "0x104034B0")]
    private void Start()
    {
    }

    [Token(Token = "0x6007FAE")]
    [Address(RVA = "0x403170", Offset = "0x401F70", VA = "0x10403170")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6007FAF")]
    [Address(RVA = "0x402E20", Offset = "0x401C20", VA = "0x10402E20")]
    private void OnAbilityRankUpCountChange(int count)
    {
    }

    [Token(Token = "0x6007FB0")]
    [Address(RVA = "0x402BE0", Offset = "0x4019E0", VA = "0x10402BE0")]
    private void Clicked(SRPG_Button button)
    {
    }

    [Token(Token = "0x6007FB1")]
    [Address(RVA = "0x403000", Offset = "0x401E00", VA = "0x10403000")]
    private void OnDecide(int value)
    {
    }

    [Token(Token = "0x6007FB2")]
    [Address(RVA = "0x402E40", Offset = "0x401C40", VA = "0x10402E40")]
    private void OnAccept(GameObject go)
    {
    }

    [Token(Token = "0x6007FB3")]
    [Address(RVA = "0x4032C0", Offset = "0x4020C0", VA = "0x104032C0")]
    private void OnRequestResult(WWWResult www)
    {
    }

    [Token(Token = "0x6007FB4")]
    [Address(RVA = "0x403630", Offset = "0x402430", VA = "0x10403630")]
    private void Success()
    {
    }

    [Token(Token = "0x6007FB5")]
    [Address(RVA = "0x403720", Offset = "0x402520", VA = "0x10403720", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6007FB6")]
    [Address(RVA = "0x403950", Offset = "0x402750", VA = "0x10403950")]
    private void Update()
    {
    }

    [Token(Token = "0x6007FB7")]
    [Address(RVA = "0x403AD0", Offset = "0x4028D0", VA = "0x10403AD0")]
    public AbilityRankUpPanel()
    {
    }

    [Token(Token = "0x2001F31")]
    public delegate void ResetAbilityRankUpCountEvent();
  }
}
