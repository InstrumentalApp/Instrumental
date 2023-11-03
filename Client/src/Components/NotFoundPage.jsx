import WarningTwoToneIcon from '@mui/icons-material/WarningTwoTone';
import HoverButton from './HoverButton';
import styles from '../Styles/App';
import Typography from '@mui/material/Typography';

const NotFoundPage = () => {
  return(
    <div style={{ 
      textAlign:"center",
      margin: "auto",
      height: "100vh",
      display: "flex",
      flexDirection: "column",
      justifyContent: "center", 
      alignItems: "center",
      backgroundColor: styles.colors.TERTIARY,
    }}>
      <WarningTwoToneIcon sx={{ fontSize: 100, color: styles.colors.ACTION }}/>
      <Typography variant='h5' fontFamily={styles.fonts.LOGO_FONT} mt={3} mb={5}>
        Sorry, the page you are looking for is not currently available.
      </Typography>
      <HoverButton link="/" 
        backgroundColor={styles.colors.ACTION}
      >
        Return to Homepage
      </HoverButton>
    </div>
  )
};
export default NotFoundPage;