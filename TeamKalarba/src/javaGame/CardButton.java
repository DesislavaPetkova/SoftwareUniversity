package javaGame;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.GridLayout;

import javax.swing.JFrame;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.util.Random;

import javax.swing.JButton;
import javax.swing.ImageIcon;
import javax.swing.Icon;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.Timer;

public class CardButton extends JFrame {
	Clicked handler = new Clicked();
	JFrame game = new JFrame("Card Match Game");
	JPanel playfield = new JPanel();
	JPanel playerPanel = new JPanel();
	JLabel displayText[] = new JLabel[4];
	JButton restartGame = new JButton("Play Again");
	JButton hold;
	JButton held;
	int player = 0;
	int counter = 0;
	int temp = 0;

	boolean nextTime = false;
	Icon pic1;
	Icon pic2;
	int score = 0;
	int scorecounter = 0;

	public JButton buttons[] = new JButton[16];
	public ImageIcon imagesicons[] = new ImageIcon[16];

	public CardButton() {

		playfield.setLayout(new GridLayout(4, 4, 14, 14));
		playerPanel.setLayout(new GridLayout(1, 4));
		playerPanel.setBackground(new Color(0, 192, 128));

		// generate the buttons
		for (int i = 0; i < 16; i++) {
			buttons[i] = new JButton();
			buttons[i].setBackground(new Color(0, 128, 192));
			buttons[i].addActionListener(handler);// add button to action
													// listener
			playfield.add(buttons[i]);// add button to panel
		}

		// generate text labels
		for (int i = 0; i < 4; i++) {
			displayText[i] = new JLabel();
			playerPanel.add(displayText[i]);
		}
		displayText[0].setText("        Player's score:");
		displayText[1].setText("0");
		displayText[2].setText("Current best result:");
		displayText[3].setText("0");
		game.setSize(600, 620);
		game.setResizable(true);
		game.setVisible(true);
		game.getContentPane().add(playerPanel, BorderLayout.SOUTH);
		game.getContentPane().add(playfield, BorderLayout.CENTER);
		game.setDefaultCloseOperation(EXIT_ON_CLOSE);

		// generate array with random images
		int counter1 = 0;
		int counter2 = 0;
		int counter3 = 0;
		int counter4 = 0;
		int counter5 = 0;
		int counter6 = 0;
		int counter7 = 0;
		int counter8 = 0;
		for (int i = 0; i < 16; i++) {
			Random rnd = new Random();
			int num = 1 + rnd.nextInt(8);

			switch (num) {
			case 1:
				if (counter1 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter1++;
				}

				else {
					i--;
					continue;
				}

				break;
			case 2:
				if (counter2 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter2++;
				}

				else {
					i--;
					continue;
				}

				break;
			case 3:
				if (counter3 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter3++;
				}

				else {
					i--;
					continue;
				}

				break;
			case 4:
				if (counter4 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter4++;
				}

				else {
					i--;
					continue;
				}

				break;
			case 5:
				if (counter5 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter5++;
				}

				else {
					i--;
					continue;
				}

				break;
			case 6:
				if (counter6 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter6++;
				}

				else {
					i--;
					continue;
				}

				break;
			case 7:
				if (counter7 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter7++;
				}

				else {
					i--;
					continue;
				}

				break;
			case 8:
				if (counter8 < 2) {
					imagesicons[i] = new ImageIcon(getClass().getResource(
							(num) + ".png"));
					counter8++;
				}

				else {
					i--;
					continue;
				}

				break;

			}

		}

		restartGame.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent a) {
				score = 0;
				scorecounter = 0;
				nextTime = true;
				displayText[1].setText(score + "");
				// set all icons on buttons to null
				for (int i = 0; i < 16; i++) {

					buttons[i].setIcon(null);
					imagesicons[i] = null;

				}
				int counter1 = 0;
				int counter2 = 0;
				int counter3 = 0;
				int counter4 = 0;
				int counter5 = 0;
				int counter6 = 0;
				int counter7 = 0;
				int counter8 = 0;
				// generate again the array with random images
				for (int i = 0; i < 16; i++) {
					Random rnd = new Random();
					int num = 1 + rnd.nextInt(8);

					switch (num) {
					case 1:
						if (counter1 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter1++;
						}

						else {
							i--;
							continue;
						}

						break;
					case 2:
						if (counter2 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter2++;
						}

						else {
							i--;
							continue;
						}

						break;
					case 3:
						if (counter3 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter3++;
						}

						else {
							i--;
							continue;
						}

						break;
					case 4:
						if (counter4 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter4++;
						}

						else {
							i--;
							continue;
						}

						break;
					case 5:
						if (counter5 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter5++;
						}

						else {
							i--;
							continue;
						}

						break;
					case 6:
						if (counter6 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter6++;
						}

						else {
							i--;
							continue;
						}

						break;
					case 7:
						if (counter7 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter7++;
						}

						else {
							i--;
							continue;
						}

						break;
					case 8:
						if (counter8 < 2) {
							imagesicons[i] = new ImageIcon(getClass()
									.getResource((num) + ".png"));
							counter8++;
						}

						else {
							i--;
							continue;
						}

						break;

					}

				}

			}
		});
		restartGame.setBackground(Color.orange);

		playerPanel.add(restartGame);

	}

	// handling events
	private class Clicked implements ActionListener {

		public void actionPerformed(ActionEvent e) {
			int i;
			hold = (JButton) e.getSource();
			if (hold.getIcon() == null) {
				for (i = 0; buttons[i] != hold; i++) {

				}
				if (counter == 0) {

					hold.setIcon(imagesicons[i]);
					pic2 = imagesicons[i];
					counter++;
					held = hold;
				} else {

					hold.setIcon(imagesicons[i]);
					pic1 = imagesicons[i];
					countScore(pic1, hold);
					counter = 0;

				}

			}

		}

		// count score
		private void countScore(Icon pic1, JButton hold) {

			if (pic1.toString().equals(pic2.toString())
					|| pic1.toString().equals("8.png")
					|| pic2.toString().equals("8.png")) {
				score += 10;
				displayText[1].setText(score + "");

			} else {
				// hide the two icons
				Timer t = new Timer(200, new ActionListener() {

					public void actionPerformed(ActionEvent e) {
						hold.setIcon(null);
						scorecounter++;

						held.setIcon(null);

					}
				});
				t.setRepeats(false);
				t.start();

			}
			if (score == 80) {
				JOptionPane.showMessageDialog(null, "You made " + scorecounter
						+ " clicks");

				if (nextTime == true) {
					if (scorecounter < temp) {
						JOptionPane.showMessageDialog(null, "Best result! "
								+ scorecounter + " clicks");
						displayText[3].setText(scorecounter + " clicks");
						temp = scorecounter;

					} else {

						displayText[3].setText(temp + "");

					}

				} else {
					displayText[3].setText(scorecounter + " clicks");
					temp = scorecounter;
					nextTime = true;

				}

			}

		}
	}

	public static void main(String[] args) throws Exception {
		CardButton play = new CardButton();
	}
}
