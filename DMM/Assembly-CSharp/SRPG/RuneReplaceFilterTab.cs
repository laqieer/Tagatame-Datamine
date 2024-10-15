// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceFilterTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029C5")]
  [AddComponentMenu("UI/Filter/Tab/RuneReplace")]
  public class RuneReplaceFilterTab : MonoBehaviour
  {
    [Token(Token = "0x400CA9A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mToggle;
    [Token(Token = "0x400CA9B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string mDefaultTextKey;
    [Token(Token = "0x400CA9C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CA9D")]
    [FieldOffset(Offset = "0x18")]
    private RuneReplaceFilterTabModel mModel;

    [Token(Token = "0x170019A8")]
    public Toggle Toggle
    {
      [Token(Token = "0x600BE0C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x170019A9")]
    public string TabKey
    {
      [Token(Token = "0x600BE0D"), Address(RVA = "0x858ED0", Offset = "0x857CD0", VA = "0x10858ED0")] set
      {
      }
      [Token(Token = "0x600BE0E"), Address(RVA = "0x858DE0", Offset = "0x857BE0", VA = "0x10858DE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170019AA")]
    public string TabText
    {
      [Token(Token = "0x600BE0F"), Address(RVA = "0x858F00", Offset = "0x857D00", VA = "0x10858F00")] set
      {
      }
      [Token(Token = "0x600BE10"), Address(RVA = "0x858E20", Offset = "0x857C20", VA = "0x10858E20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170019AB")]
    public bool isOn
    {
      [Token(Token = "0x600BE11"), Address(RVA = "0x858E60", Offset = "0x857C60", VA = "0x10858E60")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BE12"), Address(RVA = "0x858F20", Offset = "0x857D20", VA = "0x10858F20")] set
      {
      }
    }

    [Token(Token = "0x600BE13")]
    [Address(RVA = "0x858CA0", Offset = "0x857AA0", VA = "0x10858CA0")]
    public void SetInitToggle(bool isOn)
    {
    }

    [Token(Token = "0x600BE14")]
    [Address(RVA = "0x858CF0", Offset = "0x857AF0", VA = "0x10858CF0")]
    public void SetIsFiltered(bool isFiltered)
    {
    }

    [Token(Token = "0x600BE15")]
    [Address(RVA = "0x858B80", Offset = "0x857980", VA = "0x10858B80")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BE16")]
    [Address(RVA = "0x858BA0", Offset = "0x8579A0", VA = "0x10858BA0")]
    public void Initialize(RuneReplaceFilterTabModel model)
    {
    }

    [Token(Token = "0x600BE17")]
    [Address(RVA = "0x858D10", Offset = "0x857B10", VA = "0x10858D10")]
    public void Setup()
    {
    }

    [Token(Token = "0x600BE18")]
    [Address(RVA = "0x858D90", Offset = "0x857B90", VA = "0x10858D90")]
    public RuneReplaceFilterTab()
    {
    }
  }
}
