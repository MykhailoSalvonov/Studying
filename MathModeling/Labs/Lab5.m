% GR_3TEL_upr
% �������a ��������� �������� � ������� ���������� ��� S-����� GR_3TEL
% ������� �. �. 2-08-2009
clear all, clc
% 1. �������� ����� � ������� ������
mu2=0.1; mu3=0.01;
X210=1; Y210=0; Z210 =0;
V21x=0; V21y=1; V21z=0;
X320=0.1; Y320=0; Z320=0;
V32x=0; V32y=1; V32z=0;
% 6. ������ S-�����
sim('GR_3TEL')
% 3. �������������� ���-�����
load GR_3_TEL;
% 4. ������������ ������� � ������� RV ���-����� ����� ������
t=RV(1,:);
X21=RV(2,:); Y21=RV(3,:); Z21=RV(4,:);
X32=RV(5,:); Y32=RV(6,:); Z32=RV(7,:);
X13=RV(8,:); Y13=RV(9,:); Z13=RV(10,:);
X3=RV(11,:); Y3=RV(12,:); Z3=RV(13,:);
X2=RV(14,:); Y2=RV(15,:); Z2=RV(16,:);
X1=RV(17,:); Y1=RV(18,:); Z1=RV(19,:);
n=length(t);
% 5. �������� ������� ��������� ��������� ������� ��� �� ����
subplot(2,2,1)
plot(t,X21,t,Y21,'--',t,Z21,'.'), grid
set(gca, 'FontSize',14)
title('��� ������� ��� ������� �������')
xlabel('��� (�����������)')
ylabel('���������� (����������)')
legend('X_2_1','Y_2_1','Z_2_1')
% 6. �������� ������� ��������� ��������� �������� ��� �� ����
subplot(2,2,3)
n1=round(n); set(gca, 'FontSize',14)
plot(t(1:n1),X32(1:n1),t(1:n1),Y32(1:n1),'--',t(1:n1),Z32(1:n1),'.'),grid
title('��� �������� ��� ������� �������')
xlabel('��� (�����������)')
ylabel('���������� (����������)')
legend('X_3_2','Y_3_2','Z_3_2')
% 7. �������� ����������� ���������� ������� � �������� ��
subplot(4,4,[3,4,7,8,11,12])
plot3(X1,Y1,Z1,'o',X2,Y2,Z2,'.-',X3,Y3,Z3), grid
axis('square')
set(gca, 'FontSize',14)
title('��� ���� �� � ������ ����� ���������� ��','FontSize',16)
xlabel('���������� �')
ylabel('���������� Y')
zlabel('���������� Z')
legend('����� ���','����� ���','���� ���')
% 8. �������� ����������
subplot(4,4,[15,16]), axis('off')
h= text(-0.1,0.8,'���� �� (�������):', 'FontSize',14);
h= text(0.15,0.8,['\mu_1 = 1; ',sprintf('\\mu_2 = %g; ',mu2),sprintf('\\mu_3 = %g',mu3)], 'FontSize',14);
h= text(-0.1,0.650,'�������� ���������� (����������):', 'FontSize',14);
h= text(-0.1,0.50,['������� ��� ������� �������: ',sprintf('X_2_1 = %g; ',...
X210),sprintf('Y_2_1 = %g; ',Y210),sprintf('Z_2_1 = %g; ',Z210)], 'FontSize',14);
h= text(-0.1,0.35,['�������� ��� ������� �������: ',sprintf('X_3_2 = %g; ',...
X320),sprintf('Y_3_2 = %g; ',Y320),sprintf('Z_3_2 = %g; ',Z320)], 'FontSize',14);
h= text(0,0.20,'�������� �������� (����������):', 'FontSize',14);
h= text(-0.1,0.05,['������� ��� ������� �������: ',sprintf('V_2_1_x = %g; ',...
V21x),sprintf('V_2_1_y = %g; ',V21y),sprintf('V_2_1_z = %g; ',V21z)], 'FontSize',14);
h= text(-0.1,-0.1,['�������� ��� ������� �������: ',sprintf('V_3_2_x = %g; ',...
V32x),sprintf('V_3_2_y = %g; ',V32y),sprintf('V_3_2_z = %g; ',V32z)], 'FontSize',14);
h= text(-0.1,-0.2,' __________________________________________________________ ');
h= text(-0.1,-0.3,'�������� GR-3TEL-upr ����� - ������ �. �. 2-08-2009');
h= text(-0.1,-0.4,' _________________________________________________________ ');
