# Copyright 2026 Pac-Dessert1436
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

import tkinter as tk
from tkinter import ttk


class DebateRecorderApp:
    def __init__(self, root: tk.Tk) -> None:
        self.root = root
        self.root.title("辩论记录应用 - python tkinter")
        self.root.geometry("800x600")
        self.root.minsize(600, 400)

        self.create_widgets()

    def create_widgets(self) -> None:
        main_frame = ttk.PanedWindow(self.root, orient=tk.VERTICAL)
        main_frame.pack(fill=tk.BOTH, expand=True)

        pro_frame = self.create_team_frame("正方", "#ADD8E6")
        con_frame = self.create_team_frame("反方", "#FFB6C1")

        main_frame.add(pro_frame, weight=1)
        main_frame.add(con_frame, weight=1)

    def create_team_frame(self, team_name: str, bg_color: str) -> ttk.Frame:
        frame = ttk.Frame(self.root)

        header_frame = tk.Frame(frame, bg=bg_color)
        header_frame.pack(fill=tk.X, padx=5, pady=5)

        label = tk.Label(header_frame, text=f"{team_name}：", bg=bg_color)
        label.pack(side=tk.LEFT, padx=2)

        team_name_entry = tk.Entry(header_frame, width=15)
        team_name_entry.insert(0, "填入队伍名称")
        team_name_entry.pack(side=tk.LEFT, padx=2)

        position_label = tk.Label(header_frame, text="观点：", bg=bg_color)
        position_label.pack(side=tk.LEFT, padx=2)

        position_entry = tk.Entry(header_frame, width=25)
        position_entry.insert(0, "填入所持观点")
        position_entry.pack(side=tk.LEFT, padx=2)

        score_label = tk.Label(header_frame, text="当前得分：", bg=bg_color)
        score_label.pack(side=tk.LEFT, padx=2)

        score_spin = tk.Spinbox(header_frame, from_=0, to=10, width=8)
        score_spin.delete(0, tk.END)
        score_spin.insert(0, "0")
        score_spin.pack(side=tk.LEFT, padx=2)

        text_frame = ttk.Frame(frame)
        text_frame.pack(fill=tk.BOTH, expand=True, padx=5, pady=(0, 5))

        records_text = tk.Text(text_frame, wrap=tk.WORD, height=15)
        records_text.pack(fill=tk.BOTH, expand=True)

        return frame


if __name__ == "__main__":
    root = tk.Tk()
    app = DebateRecorderApp(root)
    root.mainloop()
