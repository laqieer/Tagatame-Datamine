// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSortTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FE7")]
  public class ArtifactSortTab : MonoBehaviour
  {
    [Token(Token = "0x4008788")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mTabName;
    [Token(Token = "0x4008789")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle ToggleButton;

    [Token(Token = "0x170012D9")]
    public string TabName
    {
      [Token(Token = "0x600839D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600839E"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600839F")]
    [Address(RVA = "0x441AC0", Offset = "0x4408C0", VA = "0x10441AC0")]
    public void SetUp(ArtifactSortWindow _window, string _tab_name, bool _is_on)
    {
    }

    [Token(Token = "0x60083A0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactSortTab()
    {
    }
  }
}
