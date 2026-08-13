using System;
using System.Windows.Forms;

namespace Kiosk
{
    public static class LanguageManager
    {
        // 0: English, 1: Japanese, 2: Korean
        public static int CurrentLanguageIndex { get; private set; } = 2; // Default is Korean

        // Event fired when the language is changed
        public static event Action? LanguageChanged;

        public static void SetLanguage(int index)
        {
            CurrentLanguageIndex = index;
            LanguageChanged?.Invoke();
        }

    }

    public class BaseLanguageForm : Form
    {
        public BaseLanguageForm()
        {
            // 언어 변경 이벤트 구독
            LanguageManager.LanguageChanged += ApplyLanguageInternal;

            // 폼이 닫힐 때 이벤트 구독 해제 (메모리 누수 방지)
            this.FormClosed += (s, e) => {
                LanguageManager.LanguageChanged -= ApplyLanguageInternal;
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 최초 1회 언어 적용
            ApplyLanguage();
        }

        private void ApplyLanguageInternal()
        {
            if (!this.IsDisposed)
            {
                ApplyLanguage();
            }
        }

        // 상속받는 하위 폼에서 오버라이드하여 각자 컨트롤의 번역 텍스트를 대입합니다.
        protected virtual void ApplyLanguage()
        {
        }
    }
}
